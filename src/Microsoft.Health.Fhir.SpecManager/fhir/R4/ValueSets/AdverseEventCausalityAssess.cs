// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Codes for the assessment of whether the entity caused the event.
  /// </summary>
  public static class AdverseEventCausalityAssessCodes
  {
    /// <summary>
    /// i) Event or laboratory test abnormality, with plausible time relationship to drug intake; ii) Cannot be explained by disease or other drugs; iii) Response to withdrawal plausible (pharmacologically, pathologically); iv) Event definitive pharmacologically or phenomenologically (i.e. an objective and specific medical disorder or a recognized pharmacological phenomenon); or v) Re-challenge satisfactory, if necessary.
    /// </summary>
    public static readonly Coding Certain = new Coding
    {
      Code = "Certain",
      Display = "Certain",
      System = "http://terminology.hl7.org/CodeSystem/adverse-event-causality-assess"
    };
    /// <summary>
    /// i) Event or laboratory test abnormality; ii) More data for proper assessment needed; or iii) Additional data under examination.
    /// </summary>
    public static readonly Coding ConditionalClassified = new Coding
    {
      Code = "Conditional-Classified",
      Display = "Conditional/Classified",
      System = "http://terminology.hl7.org/CodeSystem/adverse-event-causality-assess"
    };
    /// <summary>
    /// i) Event or laboratory test abnormality, with reasonable time relationship to drug intake; ii) Could also be explained by disease or other drugs; or iii) Information on drug withdrawal may be lacking or unclear.
    /// </summary>
    public static readonly Coding Possible = new Coding
    {
      Code = "Possible",
      Display = "Possible",
      System = "http://terminology.hl7.org/CodeSystem/adverse-event-causality-assess"
    };
    /// <summary>
    /// i) Event or laboratory test abnormality, with reasonable time relationship to drug intake; ii) Unlikely to be attributed to disease or other drugs; iii) Response to withdrawal clinically reasonable; or iv) Re-challenge not required.
    /// </summary>
    public static readonly Coding ProbablyLikely = new Coding
    {
      Code = "Probably-Likely",
      Display = "Probably/Likely",
      System = "http://terminology.hl7.org/CodeSystem/adverse-event-causality-assess"
    };
    /// <summary>
    /// i) Report suggesting an adverse reaction; ii) Cannot be judged because information is insufficient or contradictory; or iii) Data cannot be supplemented or verified.
    /// </summary>
    public static readonly Coding UnassessableUnclassifiable = new Coding
    {
      Code = "Unassessable-Unclassifiable",
      Display = "Unassessable/Unclassifiable",
      System = "http://terminology.hl7.org/CodeSystem/adverse-event-causality-assess"
    };
    /// <summary>
    /// i) Event or laboratory test abnormality, with a time to drug intake that makes a relationship improbable (but not impossible); or ii) Disease or other drugs provide plausible explanations.
    /// </summary>
    public static readonly Coding Unlikely = new Coding
    {
      Code = "Unlikely",
      Display = "Unlikely",
      System = "http://terminology.hl7.org/CodeSystem/adverse-event-causality-assess"
    };
  };
}
