// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// This example value set defines a set of codes that can be used to indicate the status of the subject within the encounter
  /// </summary>
  public static class EncounterSubjectStatusCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Arrived = new Coding
    {
      Code = "arrived",
      Display = "Arrived",
      System = "http://terminology.hl7.org/CodeSystem/encounter-subject-status"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Departed = new Coding
    {
      Code = "departed",
      Display = "Departed",
      System = "http://terminology.hl7.org/CodeSystem/encounter-subject-status"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding OnLeave = new Coding
    {
      Code = "on-leave",
      Display = "On Leave",
      System = "http://terminology.hl7.org/CodeSystem/encounter-subject-status"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Triaged = new Coding
    {
      Code = "triaged",
      Display = "Triaged",
      System = "http://terminology.hl7.org/CodeSystem/encounter-subject-status"
    };
  };
}
