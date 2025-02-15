// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Identifies the purpose of the naming system.
  /// </summary>
  public static class NamingsystemTypeCodes
  {
    /// <summary>
    /// The naming system is used to define concepts and symbols to represent those concepts; e.g. UCUM, LOINC, NDC code, local lab codes, etc.
    /// </summary>
    public static readonly Coding CodeSystem = new Coding
    {
      Code = "codesystem",
      Display = "Code System",
      System = "http://hl7.org/fhir/namingsystem-type"
    };
    /// <summary>
    /// The naming system is used to manage identifiers (e.g. license numbers, order numbers, etc.).
    /// </summary>
    public static readonly Coding Identifier = new Coding
    {
      Code = "identifier",
      Display = "Identifier",
      System = "http://hl7.org/fhir/namingsystem-type"
    };
    /// <summary>
    /// The naming system is used as the root for other identifiers and naming systems.
    /// </summary>
    public static readonly Coding Root = new Coding
    {
      Code = "root",
      Display = "Root",
      System = "http://hl7.org/fhir/namingsystem-type"
    };
  };
}
