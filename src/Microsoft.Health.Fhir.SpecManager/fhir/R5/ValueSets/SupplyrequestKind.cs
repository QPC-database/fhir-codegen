// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// This value sets refers to a Category of supply.
  /// </summary>
  public static class SupplyrequestKindCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding CentralSupply = new Coding
    {
      Code = "central",
      Display = "Central Supply",
      System = "http://terminology.hl7.org/CodeSystem/supply-kind"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding NonStock = new Coding
    {
      Code = "nonstock",
      Display = "Non-Stock",
      System = "http://terminology.hl7.org/CodeSystem/supply-kind"
    };
  };
}
