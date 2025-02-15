// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// The mode of a message capability statement.
  /// </summary>
  public static class EventCapabilityModeCodes
  {
    /// <summary>
    /// The application receives requests and sends responses.
    /// </summary>
    public static readonly Coding Receiver = new Coding
    {
      Code = "receiver",
      Display = "Receiver",
      System = "http://hl7.org/fhir/event-capability-mode"
    };
    /// <summary>
    /// The application sends requests and receives responses.
    /// </summary>
    public static readonly Coding Sender = new Coding
    {
      Code = "sender",
      Display = "Sender",
      System = "http://hl7.org/fhir/event-capability-mode"
    };
  };
}
