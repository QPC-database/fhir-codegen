// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// A code or set of codes (e.g., for routine, emergency,) specifying the urgency under which the Act happened, can happen, is happening, is intended to happen, or is requested/demanded to happen.
  /// 
  /// *Discussion:* This attribute is used in orders to indicate the ordered priority, and in event documentation it indicates the actual priority used to perform the act. In definition mood it indicates the available priorities.
  /// </summary>
  public static class V3ActPriorityCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding A = new Coding
    {
      Code = "A",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActPriority"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding CR = new Coding
    {
      Code = "CR",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActPriority"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding CallbackForScheduling = new Coding
    {
      Code = "CS",
      Display = "callback for scheduling",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActPriority"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding CallbackPlacerForScheduling = new Coding
    {
      Code = "CSP",
      Display = "callback placer for scheduling",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActPriority"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ContactRecipientForScheduling = new Coding
    {
      Code = "CSR",
      Display = "contact recipient for scheduling",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActPriority"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding EL = new Coding
    {
      Code = "EL",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActPriority"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding EM = new Coding
    {
      Code = "EM",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActPriority"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding P = new Coding
    {
      Code = "P",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActPriority"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PRN = new Coding
    {
      Code = "PRN",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActPriority"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding R = new Coding
    {
      Code = "R",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActPriority"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding RR = new Coding
    {
      Code = "RR",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActPriority"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding S = new Coding
    {
      Code = "S",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActPriority"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding T = new Coding
    {
      Code = "T",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActPriority"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding UD = new Coding
    {
      Code = "UD",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActPriority"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding UR = new Coding
    {
      Code = "UR",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActPriority"
    };
  };
}
