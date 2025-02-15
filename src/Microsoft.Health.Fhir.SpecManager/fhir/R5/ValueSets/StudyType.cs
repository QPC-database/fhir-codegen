// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The type of study the evidence was derived from.
  /// </summary>
  public static class StudyTypeCodes
  {
    /// <summary>
    /// case-control study.
    /// </summary>
    public static readonly Coding CaseControlStudy = new Coding
    {
      Code = "case-control",
      Display = "case-control study",
      System = "http://terminology.hl7.org/CodeSystem/study-type"
    };
    /// <summary>
    /// a single case report.
    /// </summary>
    public static readonly Coding CaseReport = new Coding
    {
      Code = "case-report",
      Display = "case report",
      System = "http://terminology.hl7.org/CodeSystem/study-type"
    };
    /// <summary>
    /// controlled (but not randomized) trial.
    /// </summary>
    public static readonly Coding ControlledTrialNonRandomized = new Coding
    {
      Code = "CCT",
      Display = "controlled trial (non-randomized)",
      System = "http://terminology.hl7.org/CodeSystem/study-type"
    };
    /// <summary>
    /// observational study comparing cohorts.
    /// </summary>
    public static readonly Coding ComparativeCohortStudy = new Coding
    {
      Code = "cohort",
      Display = "comparative cohort study",
      System = "http://terminology.hl7.org/CodeSystem/study-type"
    };
    /// <summary>
    /// a combination of 1 or more types of studies.
    /// </summary>
    public static readonly Coding MixedMethods = new Coding
    {
      Code = "mixed",
      Display = "mixed methods",
      System = "http://terminology.hl7.org/CodeSystem/study-type"
    };
    /// <summary>
    /// randomized controlled trial.
    /// </summary>
    public static readonly Coding RandomizedTrial = new Coding
    {
      Code = "RCT",
      Display = "randomized trial",
      System = "http://terminology.hl7.org/CodeSystem/study-type"
    };
    /// <summary>
    /// uncontrolled cohort or case series.
    /// </summary>
    public static readonly Coding UncontrolledCohortOrCaseSeries = new Coding
    {
      Code = "series",
      Display = "uncontrolled cohort or case series",
      System = "http://terminology.hl7.org/CodeSystem/study-type"
    };
  };
}
