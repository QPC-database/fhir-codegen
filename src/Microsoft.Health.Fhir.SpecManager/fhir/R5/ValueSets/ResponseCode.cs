// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The kind of response to a message.
  /// </summary>
  public static class ResponseCodeCodes
  {
    /// <summary>
    /// The message was rejected because of a problem with the content. There is no point in re-sending without change. The response narrative SHALL describe the issue.
    /// </summary>
    public static readonly Coding FatalError = new Coding
    {
      Code = "fatal-error",
      Display = "Fatal Error",
      System = "http://hl7.org/fhir/response-code"
    };
    /// <summary>
    /// The message was accepted and processed without error.
    /// </summary>
    public static readonly Coding OK = new Coding
    {
      Code = "ok",
      Display = "OK",
      System = "http://hl7.org/fhir/response-code"
    };
    /// <summary>
    /// Some internal unexpected error occurred - wait and try again. Note - this is usually used for things like database unavailable, which may be expected to resolve, though human intervention may be required.
    /// </summary>
    public static readonly Coding TransientError = new Coding
    {
      Code = "transient-error",
      Display = "Transient Error",
      System = "http://hl7.org/fhir/response-code"
    };
  };
}
