// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// SHALL applications comply with this constraint?
  /// </summary>
  public static class ConstraintSeverityCodes
  {
    /// <summary>
    /// If the constraint is violated, the resource is not conformant.
    /// </summary>
    public static readonly Coding Error = new Coding
    {
      Code = "error",
      Display = "Error",
      System = "http://hl7.org/fhir/constraint-severity"
    };
    /// <summary>
    /// If the constraint is violated, the resource is conformant, but it is not necessarily following best practice.
    /// </summary>
    public static readonly Coding Warning = new Coding
    {
      Code = "warning",
      Display = "Warning",
      System = "http://hl7.org/fhir/constraint-severity"
    };
  };
}
