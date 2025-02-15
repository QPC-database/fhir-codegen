﻿// <copyright file="Program.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

using System;
using System.Collections.Generic;
using System.CommandLine.Builder;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.Health.Fhir.SpecManager.Language;
using Microsoft.Health.Fhir.SpecManager.Manager;
using Microsoft.Health.Fhir.SpecManager.Models;

namespace FhirCodegenCli
{
    /// <summary>FHIR CodeGen CLI.</summary>
    public static class Program
    {
        private static HashSet<string> _extensionsOutputted;

        /// <summary>
        /// Command-line utility for processing the FHIR specification into other computer languages.
        /// </summary>
        /// <param name="fhirSpecDirectory">     The full path to the directory where FHIR specifications
        ///  are downloaded and cached.</param>
        /// <param name="outputPath">            File or directory to write output.</param>
        /// <param name="verbose">               Show verbose output.</param>
        /// <param name="offlineMode">           Offline mode (will not download missing specs).</param>
        /// <param name="language">              Name of the language to export (default:
        ///  Info|TypeScript|CSharpBasic).</param>
        /// <param name="exportKeys">            '|' separated list of items to export (not present to
        ///  export everything).</param>
        /// <param name="loadR2">                If FHIR R2 should be loaded, which version (e.g., 1.0.2
        ///  or latest).</param>
        /// <param name="loadR3">                If FHIR R3 should be loaded, which version (e.g., 3.0.2
        ///  or latest).</param>
        /// <param name="loadR4">                If FHIR R4 should be loaded, which version (e.g., 4.0.1
        ///  or latest).</param>
        /// <param name="loadR5">                If FHIR R5 should be loaded, which version (e.g., 4.4.0
        ///  or latest).</param>
        /// <param name="languageOptions">       Language specific options, see documentation for more
        ///  details. Example: Lang1|opt=a|opt2=b|Lang2|opt=tt|opt3=oo.</param>
        /// <param name="officialExpansionsOnly">True to restrict value-sets exported to only official
        ///  expansions (default: false).</param>
        /// <param name="fhirServerUrl">         FHIR Server URL to pull a CapabilityStatement (or
        ///  Conformance) from.  Requires application/fhir+json.</param>
        /// <param name="includeExperimental">   If the output should include structures marked
        ///  experimental (false|true).</param>
        /// <param name="exportTypes">           Which FHIR classes types to export
        ///  (primitive|complex|resource|interaction|enum), default is all.</param>
        /// <param name="extensionSupport">      The level of extensions to include
        ///  (none|official|officialNonPrimitive|nonPrimitive|all), default is nonPrimitive.</param>
        /// <param name="languageHelp">          Display languages and their options.</param>
        /// <param name="fhirPublishDirectory">  The full path to a local FHIR build publish directory (.../publish).</param>
        /// <param name="loadLocalFhirBuild">    "latest" to copy from a local FHIR build directory, "current" to use a previous copy (default: not present).</param>
        public static void Main(
            string fhirSpecDirectory = "",
            string outputPath = "",
            bool verbose = false,
            bool offlineMode = false,
            string language = "",
            string exportKeys = "",
            string loadR2 = "",
            string loadR3 = "",
            string loadR4 = "",
            string loadR5 = "",
            string languageOptions = "",
            bool officialExpansionsOnly = false,
            string fhirServerUrl = "",
            bool includeExperimental = false,
            string exportTypes = "",
            string extensionSupport = "",
            bool languageHelp = false,
            string fhirPublishDirectory = "",
            string loadLocalFhirBuild = "")
        {
            if (languageHelp)
            {
                ShowLanguageHelp(language);
                return;
            }

            bool isBatch = false;
            string currentFilePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            List<string> filesWritten = new List<string>();

            _extensionsOutputted = new HashSet<string>();

            if (string.IsNullOrEmpty(fhirSpecDirectory))
            {
                fhirSpecDirectory = FindFhirDir(currentFilePath, "fhirVersions");
            }

            if (!string.IsNullOrEmpty(loadLocalFhirBuild))
            {
                if (string.IsNullOrEmpty(fhirPublishDirectory))
                {
                    fhirPublishDirectory = Path.Combine(currentFilePath, "..", "..", "..", "..", "..", "..", "fhir", "publish");
                }
            }
            else
            {
                fhirPublishDirectory = string.Empty;
            }

            if (string.IsNullOrEmpty(outputPath))
            {
                outputPath = FindFhirDir(currentFilePath, "generated");
            }

            if (string.IsNullOrEmpty(language))
            {
                language = "Info|TypeScript|CSharpBasic";
            }

            exportTypes ??= string.Empty;

            List<ExporterOptions.FhirExportClassType> typesToExport = exportTypes
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .Select(et => GetExportClass(et))
                .Where(et => et != null)
                .Select(et => et.Value)
                .ToList();

            static ExporterOptions.FhirExportClassType? GetExportClass(string val)
            {
                return val.ToUpperInvariant() switch
                {
                    "PRIMITIVE" => ExporterOptions.FhirExportClassType.PrimitiveType,
                    "COMPLEX" => ExporterOptions.FhirExportClassType.ComplexType,
                    "RESOURCE" => ExporterOptions.FhirExportClassType.Resource,
                    "INTERACTION" => ExporterOptions.FhirExportClassType.Interaction,
                    "ENUM" => ExporterOptions.FhirExportClassType.Enum,
                    _ => null
                };
            }

            ExporterOptions.ExtensionSupportLevel extensionSupportLevel = GetExtensionSupport(extensionSupport);

            static ExporterOptions.ExtensionSupportLevel GetExtensionSupport(string val)
            {
                if (string.IsNullOrEmpty(val))
                {
                    return ExporterOptions.ExtensionSupportLevel.NonPrimitive;
                }

                return val.ToUpperInvariant() switch
                {
                    "NONE" => ExporterOptions.ExtensionSupportLevel.None,
                    "OFFICIAL" => ExporterOptions.ExtensionSupportLevel.Official,
                    "OFFICIALNONPRIMITIVE" => ExporterOptions.ExtensionSupportLevel.OfficialNonPrimitive,
                    "ALL" => ExporterOptions.ExtensionSupportLevel.All,
                    "NONPRIMITIVE" => ExporterOptions.ExtensionSupportLevel.NonPrimitive,
                    "BYEXTENSIONURL" => ExporterOptions.ExtensionSupportLevel.ByExtensionUrl,
                    "BYELEMENTPATH" => ExporterOptions.ExtensionSupportLevel.ByElementPath,
                    _ => ExporterOptions.ExtensionSupportLevel.NonPrimitive,
                };
            }

            // start timing
            Stopwatch timingWatch = Stopwatch.StartNew();

            // initialize the FHIR version manager with our requested directory
            FhirManager.Init(fhirSpecDirectory, fhirPublishDirectory);

            FhirVersionInfo r2 = null;
            FhirVersionInfo r3 = null;
            FhirVersionInfo r4 = null;
            FhirVersionInfo r5 = null;
            FhirVersionInfo localVersion = null;

            FhirServerInfo serverInfo = null;

            if (!string.IsNullOrEmpty(fhirServerUrl))
            {
                if (!ServerConnector.TryGetServerInfo(fhirServerUrl, out serverInfo))
                {
                    Console.WriteLine($"Failed to get server information from {fhirServerUrl}!");
                    return;
                }
            }

            if (string.IsNullOrEmpty(loadR2) &&
                string.IsNullOrEmpty(loadR3) &&
                string.IsNullOrEmpty(loadR4) &&
                string.IsNullOrEmpty(loadR5) &&
                string.IsNullOrEmpty(loadLocalFhirBuild))
            {
                if (serverInfo == null)
                {
                    loadR2 = "latest";
                    loadR3 = "latest";
                    loadR4 = "latest";
                    loadR5 = "latest";
                }
                else
                {
                    switch (serverInfo.MajorVersion)
                    {
                        case 2:
                            loadR2 = "latest";
                            break;

                        case 3:
                            loadR3 = "latest";
                            break;

                        case 4:
                            loadR4 = "latest";
                            break;

                        case 5:
                            loadR5 = "latest";
                            break;
                    }
                }
            }

            int fhirVersionCount = 0;
            if (!string.IsNullOrEmpty(loadR2))
            {
                r2 = FhirManager.Current.LoadPublished(2, loadR2, offlineMode, officialExpansionsOnly);
                fhirVersionCount++;
            }

            if (!string.IsNullOrEmpty(loadR3))
            {
                r3 = FhirManager.Current.LoadPublished(3, loadR3, offlineMode, officialExpansionsOnly);
                fhirVersionCount++;
            }

            if (!string.IsNullOrEmpty(loadR4))
            {
                r4 = FhirManager.Current.LoadPublished(4, loadR4, offlineMode, officialExpansionsOnly);
                fhirVersionCount++;
            }

            if (!string.IsNullOrEmpty(loadR5))
            {
                r5 = FhirManager.Current.LoadPublished(5, loadR5, offlineMode, officialExpansionsOnly);
                fhirVersionCount++;
            }

            if (!string.IsNullOrEmpty(loadLocalFhirBuild))
            {
                localVersion = FhirManager.Current.LoadLocal(loadLocalFhirBuild, officialExpansionsOnly);
                fhirVersionCount++;
            }

            if (fhirVersionCount > 1)
            {
                isBatch = true;
            }

            // done loading
            long loadMS = timingWatch.ElapsedMilliseconds;

            if (string.IsNullOrEmpty(outputPath))
            {
                if ((verbose == true) && (r2 != null))
                {
                    DumpFhirVersion(Console.Out, r2);
                }

                if ((verbose == true) && (r3 != null))
                {
                    DumpFhirVersion(Console.Out, r3);
                }

                if ((verbose == true) && (r4 != null))
                {
                    DumpFhirVersion(Console.Out, r4);
                }

                if ((verbose == true) && (r5 != null))
                {
                    DumpFhirVersion(Console.Out, r5);
                }

                if ((verbose == true) && (localVersion != null))
                {
                    DumpFhirVersion(Console.Out, localVersion);
                }
            }

            if (!string.IsNullOrEmpty(outputPath))
            {
                string baseDirectory;

                if (Path.HasExtension(outputPath))
                {
                    baseDirectory = Path.GetDirectoryName(outputPath);
                }
                else
                {
                    baseDirectory = outputPath;
                }

                if (!Directory.Exists(Path.GetDirectoryName(baseDirectory)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(baseDirectory));
                }

                List<ILanguage> languages = LanguageHelper.GetLanguages(language);

                Dictionary<string, Dictionary<string, string>> languageOptsByLang = ParseLanguageOptions(
                    languageOptions,
                    languages);

                if (languages.Count > 1)
                {
                    isBatch = true;
                }

                foreach (ILanguage lang in languages)
                {
                    string[] exportList = null;

                    if (!string.IsNullOrEmpty(exportKeys))
                    {
                        exportList = exportKeys.Split('|');
                    }

                    // for now, just include every optional type
                    ExporterOptions options = new ExporterOptions(
                        lang.LanguageName,
                        exportList,
                        typesToExport.Any() ? typesToExport : lang.OptionalExportClassTypes,
                        extensionSupportLevel,
                        null,
                        null,
                        languageOptsByLang[lang.LanguageName],
                        fhirServerUrl,
                        includeExperimental);

                    if (r2 != null)
                    {
                        filesWritten.AddRange(Exporter.Export(r2, serverInfo, lang, options, outputPath, isBatch));
                    }

                    if (r3 != null)
                    {
                        filesWritten.AddRange(Exporter.Export(r3, serverInfo, lang, options, outputPath, isBatch));
                    }

                    if (r4 != null)
                    {
                        filesWritten.AddRange(Exporter.Export(r4, serverInfo, lang, options, outputPath, isBatch));
                    }

                    if (r5 != null)
                    {
                        filesWritten.AddRange(Exporter.Export(r5, serverInfo, lang, options, outputPath, isBatch));
                    }

                    if (localVersion != null)
                    {
                        filesWritten.AddRange(Exporter.Export(localVersion, serverInfo, lang, options, outputPath, isBatch));
                    }
                }
            }

            // done
            long totalMS = timingWatch.ElapsedMilliseconds;

            Console.WriteLine($"Done! Loading: {loadMS / 1000.0}s, Total: {totalMS / 1000.0}s");

            foreach (string file in filesWritten)
            {
                Console.WriteLine($"+ {file}");
            }
        }

        /// <summary>Searches for the FHIR specification directory.</summary>
        /// <exception cref="DirectoryNotFoundException">Thrown when the requested directory is not
        ///  present.</exception>
        /// <param name="startingDir">The starting dir.</param>
        /// <param name="dirName">    The name of the directory we are searching for.</param>
        /// <returns>The found FHIR directory.</returns>
        public static string FindFhirDir(string startingDir, string dirName)
        {
            string currentDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string testDir = Path.Combine(currentDir, dirName);

            while (!Directory.Exists(testDir))
            {
                currentDir = Path.GetFullPath(Path.Combine(currentDir, ".."));

                if (currentDir == Path.GetPathRoot(currentDir))
                {
                    throw new DirectoryNotFoundException("Could not find spec directory in path!");
                }

                testDir = Path.Combine(currentDir, dirName);
            }

            return testDir;
        }

        /// <summary>Shows the language help.</summary>
        /// <param name="languageName">(Optional) Name of the language.</param>
        private static void ShowLanguageHelp(string languageName = "")
        {
            if (string.IsNullOrEmpty(languageName))
            {
                languageName = "*";
            }

            List<ILanguage> languages = LanguageHelper.GetLanguages(languageName);

            foreach (ILanguage language in languages.OrderBy(l => l.LanguageName))
            {
                Console.WriteLine($"- {language.LanguageName}");

                if ((language.LanguageOptions == null) || (language.LanguageOptions.Count == 0))
                {
#pragma warning disable CA1303 // Do not pass literals as localized parameters
                    Console.WriteLine("\t- No extended options are available.");
#pragma warning restore CA1303 // Do not pass literals as localized parameters
                    continue;
                }

                foreach (KeyValuePair<string, string> kvp in language.LanguageOptions)
                {
                    Console.WriteLine($"\t- {kvp.Key}\n\t\t{kvp.Value}");
                }
            }
        }

        /// <summary>Gets options for language.</summary>
        /// <param name="languageOptions">Options for controlling the language.</param>
        /// <param name="languages">      The languages.</param>
        /// <returns>The options for each language.</returns>
        private static Dictionary<string, Dictionary<string, string>> ParseLanguageOptions(
            string languageOptions,
            List<ILanguage> languages)
        {
            Dictionary<string, Dictionary<string, string>> optionsByLanguage = new Dictionary<string, Dictionary<string, string>>();

            if ((languages == null) || (languages.Count == 0))
            {
                return optionsByLanguage;
            }

            foreach (ILanguage lang in languages)
            {
                optionsByLanguage.Add(lang.LanguageName, new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase));
            }

            if (string.IsNullOrEmpty(languageOptions))
            {
                return optionsByLanguage;
            }

            string[] segments = languageOptions.Split('|');

            if (segments.Length < 2)
            {
                return optionsByLanguage;
            }

            string currentName = string.Empty;
            string lastName = string.Empty;

            foreach (string segment in segments)
            {
                if (string.IsNullOrEmpty(segment))
                {
                    continue;
                }

                string[] kvp = segment.Split('=');

                // segment without '=' is a language name
                if (kvp.Length == 1)
                {
                    currentName = string.Empty;

                    foreach (ILanguage lang in languages)
                    {
                        if (lang.LanguageName.ToUpperInvariant() != lastName)
                        {
                            lastName = lang.LanguageName.ToUpperInvariant();
                            currentName = lang.LanguageName;

                            break;
                        }
                    }

                    continue;
                }

                if (string.IsNullOrEmpty(currentName))
                {
                    continue;
                }

                // don't worry about inline '=' symbols yet - add only if it becomes necessary in the CLI
                if (kvp.Length != 2)
                {
                    Console.WriteLine($"Invalid language option: {segment} for language: {currentName}");
                    continue;
                }

                string key = kvp[0].ToUpperInvariant();

                if (optionsByLanguage[currentName].ContainsKey(key))
                {
                    Console.WriteLine($"Invalid language option redefinition: {segment} for language: {currentName}");
                    continue;
                }

                optionsByLanguage[currentName].Add(key, kvp[1]);
            }

            return optionsByLanguage;
        }

        /// <summary>Dumps information about a FHIR version to the console.</summary>
        /// <param name="writer">The writer.</param>
        /// <param name="info">  The FHIR information.</param>
        private static void DumpFhirVersion(TextWriter writer, FhirVersionInfo info)
        {
            // tell the user what's going on
            writer.WriteLine($"Contents of: {info.PackageName} version: {info.VersionString}");

            // dump primitive types
            writer.WriteLine($"primitive types: {info.PrimitiveTypes.Count}");

            foreach (FhirPrimitive primitive in info.PrimitiveTypes.Values)
            {
                writer.WriteLine($"- {primitive.Name}: {primitive.BaseTypeName}");

                // check for extensions
                if (info.ExtensionsByPath.ContainsKey(primitive.Name))
                {
                    DumpExtensions(writer, info, info.ExtensionsByPath[primitive.Name].Values, 2);
                }
            }

            // dump complex types
            writer.WriteLine($"complex types: {info.ComplexTypes.Count}");
            DumpComplexDict(writer, info, info.ComplexTypes);

            // dump resources
            writer.WriteLine($"resources: {info.Resources.Count}");
            DumpComplexDict(writer, info, info.Resources);

            // dump server level operations
            writer.WriteLine($"system operations: {info.SystemOperations.Count}");
            DumpOperations(writer, info.SystemOperations.Values, 0, true);

            // dump magic search parameters - all resource parameters
            writer.WriteLine($"all resource parameters: {info.AllResourceParameters.Count}");
            DumpSearchParameters(writer, info.AllResourceParameters.Values, 0);

            // dump magic search parameters - search result parameters
            writer.WriteLine($"search result parameters: {info.SearchResultParameters.Count}");
            DumpSearchParameters(writer, info.SearchResultParameters.Values, 0);

            // dump magic search parameters - search result parameters
            writer.WriteLine($"all interaction parameters: {info.AllInteractionParameters.Count}");
            DumpSearchParameters(writer, info.AllInteractionParameters.Values, 0);

            // dump extension info
            writer.WriteLine($"extensions: paths exported {_extensionsOutputted.Count} of {info.ExtensionsByUrl.Count}");
            DumpMissingExtensions(writer, info, 0);
        }

        /// <summary>Dumps a complex structure (complex type/resource and properties).</summary>
        /// <param name="writer">The writer.</param>
        /// <param name="info">  The FHIR information.</param>
        /// <param name="dict">  The dictionary.</param>
        private static void DumpComplexDict(
            TextWriter writer,
            FhirVersionInfo info,
            Dictionary<string, FhirComplex> dict)
        {
            foreach (KeyValuePair<string, FhirComplex> kvp in dict)
            {
                DumpComplex(writer, info, kvp.Value);
            }
        }

        /// <summary>Dumps a complex element.</summary>
        /// <param name="writer">     The writer.</param>
        /// <param name="info">       The FHIR information.</param>
        /// <param name="complex">    The complex.</param>
        /// <param name="indentation">(Optional) The indentation.</param>
        private static void DumpComplex(
            TextWriter writer,
            FhirVersionInfo info,
            FhirComplex complex,
            int indentation = 0)
        {
            // write this type's line, if it's a root element
            // (sub-properties are written with cardinality in the prior loop)
            if (indentation == 0)
            {
                writer.WriteLine($"{new string(' ', indentation)}- {complex.Name}: {complex.BaseTypeName}");
            }

            // traverse properties for this type
            foreach (FhirElement element in complex.Elements.Values.OrderBy(s => s.FieldOrder))
            {
                string max = (element.CardinalityMax == -1) ? "*" : $"{element.CardinalityMax}";

                string propertyType = string.Empty;

                if (element.ElementTypes != null)
                {
                    foreach (FhirElementType elementType in element.ElementTypes.Values)
                    {
                        string joiner = string.IsNullOrEmpty(propertyType) ? string.Empty : "|";

                        string profiles = string.Empty;
                        if ((elementType.Profiles != null) && (elementType.Profiles.Count > 0))
                        {
                            profiles = "(" + string.Join('|', elementType.Profiles.Values) + ")";
                        }

                        propertyType = $"{propertyType}{joiner}{elementType.Name}{profiles}";
                    }
                }

                if (string.IsNullOrEmpty(propertyType))
                {
                    propertyType = element.BaseTypeName;
                }

                writer.WriteLine($"{new string(' ', indentation + 2)}- {element.Name}" +
                    $"[{element.CardinalityMin}..{max}]" +
                    $": {propertyType}");

                if (!string.IsNullOrEmpty(element.DefaultFieldName))
                {
                    writer.WriteLine($"{new string(' ', indentation + 4)}" +
                        $".{element.DefaultFieldName} = {element.DefaultFieldValue}");
                }

                if (!string.IsNullOrEmpty(element.FixedFieldName))
                {
                    writer.WriteLine($"{new string(' ', indentation + 4)}" +
                        $".{element.FixedFieldName} = {element.FixedFieldValue}");
                }

                // check for an inline component definition
                if (complex.Components.ContainsKey(element.Path))
                {
                    // recurse into this definition
                    DumpComplex(writer, info, complex.Components[element.Path], indentation + 2);
                }
                else
                {
                    // only check for extensions on elements that are NOT also backbone elements (will dump there)
                    if (info.ExtensionsByPath.ContainsKey(element.Path))
                    {
                        DumpExtensions(writer, info, info.ExtensionsByPath[element.Path].Values, indentation + 2);
                    }
                }

                // check for slices
                if (element.Slicing != null)
                {
                    foreach (FhirSlicing slicing in element.Slicing.Values)
                    {
                        if (slicing.Slices.Count == 0)
                        {
                            continue;
                        }

                        string rules = string.Empty;

                        foreach (FhirSliceDiscriminatorRule rule in slicing.DiscriminatorRules.Values)
                        {
                            if (!string.IsNullOrEmpty(rules))
                            {
                                rules += ", ";
                            }

                            rules += $"{rule.DiscriminatorTypeName}@{rule.Path}";
                        }

                        writer.WriteLine(
                            $"{new string(' ', indentation + 4)}" +
                            $": {slicing.DefinedByUrl}" +
                            $" - {slicing.SlicingRules}" +
                            $" ({rules})");

                        int sliceNumber = 0;
                        foreach (FhirComplex slice in slicing.Slices)
                        {
                            writer.WriteLine($"{new string(' ', indentation + 4)}: Slice {sliceNumber++}:{slice.Name}");
                            DumpComplex(writer, info, slice, indentation + 4);
                        }
                    }
                }
            }

            // check for extensions
            if (info.ExtensionsByPath.ContainsKey(complex.Path))
            {
                DumpExtensions(writer, info, info.ExtensionsByPath[complex.Path].Values, indentation);
            }

            // dump search parameters
            if (complex.SearchParameters != null)
            {
                DumpSearchParameters(writer, complex.SearchParameters.Values, indentation);
            }

            // dump type operations
            if (complex.TypeOperations != null)
            {
                DumpOperations(writer, complex.TypeOperations.Values, indentation, true);
            }

            // dump instance operations
            if (complex.InstanceOperations != null)
            {
                DumpOperations(writer, complex.InstanceOperations.Values, indentation, false);
            }
        }

        /// <summary>Dumps the extensions.</summary>
        /// <param name="writer">     The writer.</param>
        /// <param name="info">       The FHIR information.</param>
        /// <param name="extensions"> The extensions.</param>
        /// <param name="indentation">The indentation.</param>
        private static void DumpExtensions(
            TextWriter writer,
            FhirVersionInfo info,
            IEnumerable<FhirComplex> extensions,
            int indentation)
        {
            foreach (FhirComplex extension in extensions)
            {
                DumpExtension(writer, info, extension, indentation);
            }
        }

        /// <summary>Dumps an extension.</summary>
        /// <param name="writer">     The writer.</param>
        /// <param name="info">       The FHIR information.</param>
        /// <param name="extension">  The extension.</param>
        /// <param name="indentation">The indentation.</param>
        private static void DumpExtension(
            TextWriter writer,
            FhirVersionInfo info,
            FhirComplex extension,
            int indentation)
        {
            writer.WriteLine($"{new string(' ', indentation + 2)}+{extension.URL}");

            if (extension.Elements.Count > 0)
            {
                DumpComplex(writer, info, extension, indentation + 2);
            }

            if (!_extensionsOutputted.Contains(extension.URL.ToString()))
            {
                _extensionsOutputted.Add(extension.URL.ToString());
            }
        }

        /// <summary>Dumps a missing extensions.</summary>
        /// <param name="writer">     The writer.</param>
        /// <param name="info">       The FHIR information.</param>
        /// <param name="indentation">(Optional) The indentation.</param>
        private static void DumpMissingExtensions(
            TextWriter writer,
            FhirVersionInfo info,
            int indentation = 0)
        {
            // traverse all extensions by URL and see what is missing
            foreach (KeyValuePair<string, FhirComplex> kvp in info.ExtensionsByUrl)
            {
                if (!_extensionsOutputted.Contains(kvp.Key))
                {
                    writer.WriteLine($"{new string(' ', indentation + 2)}+{kvp.Value.URL}");

                    if (kvp.Value.ContextElements != null)
                    {
                        foreach (string contextElement in kvp.Value.ContextElements)
                        {
                            writer.WriteLine($"{new string(' ', indentation + 4)}- {contextElement}");
                        }
                    }

                    if (kvp.Value.Elements.Count > 0)
                    {
                        DumpComplex(writer, info, kvp.Value, indentation + 2);
                    }
                }
            }
        }

        /// <summary>Dumps a search parameters.</summary>
        /// <param name="writer">     The writer.</param>
        /// <param name="parameters"> Options for controlling the operation.</param>
        /// <param name="indentation">The indentation.</param>
        private static void DumpSearchParameters(
            TextWriter writer,
            IEnumerable<FhirSearchParam> parameters,
            int indentation)
        {
            foreach (FhirSearchParam searchParam in parameters)
            {
                writer.WriteLine($"{new string(' ', indentation + 2)}" +
                    $"?{searchParam.Code}" +
                    $" = {searchParam.ValueType} ({searchParam.Name})");
            }
        }

        /// <summary>Dumps the operations.</summary>
        /// <param name="writer">     The writer.</param>
        /// <param name="operations"> The operations.</param>
        /// <param name="indentation">The indentation.</param>
        /// <param name="isTypeLevel">True if is type level, false if not.</param>
        private static void DumpOperations(
            TextWriter writer,
            IEnumerable<FhirOperation> operations,
            int indentation,
            bool isTypeLevel)
        {
            foreach (FhirOperation operation in operations)
            {
                if (isTypeLevel)
                {
                    writer.WriteLine($"{new string(' ', indentation + 2)}${operation.Code}");
                }
                else
                {
                    writer.WriteLine($"{new string(' ', indentation + 2)}/{{id}}${operation.Code}");
                }

                if (operation.Parameters != null)
                {
                    foreach (FhirParameter parameter in operation.Parameters.OrderBy(p => p.FieldOrder))
                    {
                        string max = (parameter.Max == null) ? "*" : parameter.Max.ToString();
                        writer.WriteLine($"{new string(' ', indentation + 4)}" +
                            $"{parameter.Use}: {parameter.Name} ({parameter.Min}-{max})");
                    }
                }
            }
        }
    }
}
