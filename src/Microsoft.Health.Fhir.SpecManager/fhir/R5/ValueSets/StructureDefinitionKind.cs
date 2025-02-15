// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Defines the type of structure that a definition is describing.
  /// </summary>
  public static class StructureDefinitionKindCodes
  {
    /// <summary>
    /// A  complex structure that defines a set of data elements that is suitable for use in 'resources'. The base specification defines a number of complex types, and other specifications can define additional types. These structures do not have a maintained identity.
    /// </summary>
    public static readonly Coding ComplexDataType = new Coding
    {
      Code = "complex-type",
      Display = "Complex Data Type",
      System = "http://hl7.org/fhir/structure-definition-kind"
    };
    /// <summary>
    /// A pattern or a template that is not intended to be a real resource or complex type.
    /// </summary>
    public static readonly Coding Logical = new Coding
    {
      Code = "logical",
      Display = "Logical",
      System = "http://hl7.org/fhir/structure-definition-kind"
    };
    /// <summary>
    /// A primitive type that has a value and an extension. These can be used throughout complex datatype, Resource and extension definitions. Only the base specification can define primitive types.
    /// </summary>
    public static readonly Coding PrimitiveDataType = new Coding
    {
      Code = "primitive-type",
      Display = "Primitive Data Type",
      System = "http://hl7.org/fhir/structure-definition-kind"
    };
    /// <summary>
    /// A 'resource' - a directed acyclic graph of elements that aggregrates other types into an identifiable entity. The base FHIR resources are defined by the FHIR specification itself but other 'resources' can be defined in additional specifications (though these will not be recognised as 'resources' by the FHIR specification (i.e. they do not get end-points etc, or act as the targets of references in FHIR defined resources - though other specificatiosn can treat them this way).
    /// </summary>
    public static readonly Coding Resource = new Coding
    {
      Code = "resource",
      Display = "Resource",
      System = "http://hl7.org/fhir/structure-definition-kind"
    };
  };
}
