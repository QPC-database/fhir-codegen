// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Preferred value set for Condition Clinical Status.
  /// </summary>
  public static class ConditionClinicalCodes
  {
    /// <summary>
    /// The subject is currently experiencing the symptoms of the condition or there is evidence of the condition.
    /// </summary>
    public static readonly Coding Active = new Coding
    {
      Code = "active",
      Display = "Active",
      System = "http://terminology.hl7.org/CodeSystem/condition-clinical"
    };
    /// <summary>
    /// The subject is no longer experiencing the symptoms of the condition or there is no longer evidence of the condition.
    /// </summary>
    public static readonly Coding Inactive = new Coding
    {
      Code = "inactive",
      Display = "Inactive",
      System = "http://terminology.hl7.org/CodeSystem/condition-clinical"
    };
    /// <summary>
    /// The subject is experiencing a re-occurence or repeating of a previously resolved condition, e.g. urinary tract infection, pancreatitis, cholangitis, conjunctivitis.
    /// </summary>
    public static readonly Coding Recurrence = new Coding
    {
      Code = "recurrence",
      Display = "Recurrence",
      System = "http://terminology.hl7.org/CodeSystem/condition-clinical"
    };
    /// <summary>
    /// The subject is experiencing a return of a condition, or signs and symptoms after a period of improvement or remission, e.g. relapse of cancer, multiple sclerosis, rheumatoid arthritis, systemic lupus erythematosus, bipolar disorder, [psychotic relapse of] schizophrenia, etc.
    /// </summary>
    public static readonly Coding Relapse = new Coding
    {
      Code = "relapse",
      Display = "Relapse",
      System = "http://terminology.hl7.org/CodeSystem/condition-clinical"
    };
    /// <summary>
    /// The subject is no longer experiencing the symptoms of the condition, but there is a risk of the symptoms returning.
    /// </summary>
    public static readonly Coding Remission = new Coding
    {
      Code = "remission",
      Display = "Remission",
      System = "http://terminology.hl7.org/CodeSystem/condition-clinical"
    };
    /// <summary>
    /// The subject is no longer experiencing the symptoms of the condition and there is a negligible perceived risk of the symptoms returning.
    /// </summary>
    public static readonly Coding Resolved = new Coding
    {
      Code = "resolved",
      Display = "Resolved",
      System = "http://terminology.hl7.org/CodeSystem/condition-clinical"
    };
  };
}
