// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The gender of a person used for administrative purposes.
  /// </summary>
  public static class AdministrativeGenderCodes
  {
    /// <summary>
    /// Female.
    /// </summary>
    public static readonly Coding Female = new Coding
    {
      Code = "female",
      Display = "Female",
      System = "http://hl7.org/fhir/administrative-gender"
    };
    /// <summary>
    /// Male.
    /// </summary>
    public static readonly Coding Male = new Coding
    {
      Code = "male",
      Display = "Male",
      System = "http://hl7.org/fhir/administrative-gender"
    };
    /// <summary>
    /// Other.
    /// </summary>
    public static readonly Coding Other = new Coding
    {
      Code = "other",
      Display = "Other",
      System = "http://hl7.org/fhir/administrative-gender"
    };
    /// <summary>
    /// Unknown.
    /// </summary>
    public static readonly Coding Unknown = new Coding
    {
      Code = "unknown",
      Display = "Unknown",
      System = "http://hl7.org/fhir/administrative-gender"
    };
  };
}
