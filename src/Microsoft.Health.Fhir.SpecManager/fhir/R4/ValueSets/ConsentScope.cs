// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// This value set includes the four Consent scope codes.
  /// </summary>
  public static class ConsentScopeCodes
  {
    /// <summary>
    /// Actions to be taken if they are no longer able to make decisions for themselves
    /// </summary>
    public static readonly Coding AdvancedCareDirective = new Coding
    {
      Code = "adr",
      Display = "Advanced Care Directive",
      System = "http://terminology.hl7.org/CodeSystem/consentscope"
    };
    /// <summary>
    /// Agreement to collect, access, use or disclose (share) information
    /// </summary>
    public static readonly Coding PrivacyConsent = new Coding
    {
      Code = "patient-privacy",
      Display = "Privacy Consent",
      System = "http://terminology.hl7.org/CodeSystem/consentscope"
    };
    /// <summary>
    /// Consent to participate in research protocol and information sharing required
    /// </summary>
    public static readonly Coding Research = new Coding
    {
      Code = "research",
      Display = "Research",
      System = "http://terminology.hl7.org/CodeSystem/consentscope"
    };
    /// <summary>
    /// Consent to undergo a specific treatment
    /// </summary>
    public static readonly Coding Treatment = new Coding
    {
      Code = "treatment",
      Display = "Treatment",
      System = "http://terminology.hl7.org/CodeSystem/consentscope"
    };
  };
}
