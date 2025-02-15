// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Defines selection frequency behavior for an action or group.
  /// </summary>
  public static class ActionPrecheckBehaviorCodes
  {
    /// <summary>
    /// An action with this behavior is one of the less frequent actions included by the end user, for the particular context in which the action occurs. The system displaying the actions to the end user would typically not "pre-check" such an action.
    /// </summary>
    public static readonly Coding No = new Coding
    {
      Code = "no",
      Display = "No",
      System = "http://hl7.org/fhir/action-precheck-behavior"
    };
    /// <summary>
    /// An action with this behavior is one of the most frequent action that is, or should be, included by an end user, for the particular context in which the action occurs. The system displaying the action to the end user should consider "pre-checking" such an action as a convenience for the user.
    /// </summary>
    public static readonly Coding Yes = new Coding
    {
      Code = "yes",
      Display = "Yes",
      System = "http://hl7.org/fhir/action-precheck-behavior"
    };
  };
}
