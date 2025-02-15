// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Defines which action to take if there is no match in the group.
  /// </summary>
  public static class ConceptmapUnmappedModeCodes
  {
    /// <summary>
    /// Use the code explicitly provided in the group.unmapped.
    /// </summary>
    public static readonly Coding FixedCode = new Coding
    {
      Code = "fixed",
      Display = "Fixed Code",
      System = "http://hl7.org/fhir/conceptmap-unmapped-mode"
    };
    /// <summary>
    /// Use the map identified by the canonical URL in the url element.
    /// </summary>
    public static readonly Coding OtherMap = new Coding
    {
      Code = "other-map",
      Display = "Other Map",
      System = "http://hl7.org/fhir/conceptmap-unmapped-mode"
    };
    /// <summary>
    /// Use the code as provided in the $translate request.
    /// </summary>
    public static readonly Coding ProvidedCode = new Coding
    {
      Code = "provided",
      Display = "Provided Code",
      System = "http://hl7.org/fhir/conceptmap-unmapped-mode"
    };
  };
}
