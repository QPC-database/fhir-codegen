// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Permitted data type for observation value.
  /// </summary>
  public static class PermittedDataTypeCodes
  {
    /// <summary>
    /// true or false.
    /// </summary>
    public static readonly Coding Boolean = new Coding
    {
      Code = "boolean",
      Display = "boolean",
      System = "http://hl7.org/fhir/permitted-data-type"
    };
    /// <summary>
    /// A coded concept from a reference terminology and/or text.
    /// </summary>
    public static readonly Coding CodeableConcept = new Coding
    {
      Code = "CodeableConcept",
      Display = "CodeableConcept",
      System = "http://hl7.org/fhir/permitted-data-type"
    };
    /// <summary>
    /// A date, date-time or partial date (e.g. just year or year + month) as used in human communication.
    /// </summary>
    public static readonly Coding DateTime = new Coding
    {
      Code = "dateTime",
      Display = "dateTime",
      System = "http://hl7.org/fhir/permitted-data-type"
    };
    /// <summary>
    /// A signed integer.
    /// </summary>
    public static readonly Coding Integer = new Coding
    {
      Code = "integer",
      Display = "integer",
      System = "http://hl7.org/fhir/permitted-data-type"
    };
    /// <summary>
    /// A time range defined by start and end date/time.
    /// </summary>
    public static readonly Coding Period = new Coding
    {
      Code = "Period",
      Display = "Period",
      System = "http://hl7.org/fhir/permitted-data-type"
    };
    /// <summary>
    /// A measured amount.
    /// </summary>
    public static readonly Coding Quantity = new Coding
    {
      Code = "Quantity",
      Display = "Quantity",
      System = "http://hl7.org/fhir/permitted-data-type"
    };
    /// <summary>
    /// A set of values bounded by low and high.
    /// </summary>
    public static readonly Coding Range = new Coding
    {
      Code = "Range",
      Display = "Range",
      System = "http://hl7.org/fhir/permitted-data-type"
    };
    /// <summary>
    /// A ratio of two Quantity values - a numerator and a denominator.
    /// </summary>
    public static readonly Coding Ratio = new Coding
    {
      Code = "Ratio",
      Display = "Ratio",
      System = "http://hl7.org/fhir/permitted-data-type"
    };
    /// <summary>
    /// A series of measurements taken by a device.
    /// </summary>
    public static readonly Coding SampledData = new Coding
    {
      Code = "SampledData",
      Display = "SampledData",
      System = "http://hl7.org/fhir/permitted-data-type"
    };
    /// <summary>
    /// A sequence of Unicode characters.
    /// </summary>
    public static readonly Coding VALString = new Coding
    {
      Code = "string",
      Display = "string",
      System = "http://hl7.org/fhir/permitted-data-type"
    };
    /// <summary>
    /// A time during the day, in the format hh:mm:ss.
    /// </summary>
    public static readonly Coding Time = new Coding
    {
      Code = "time",
      Display = "time",
      System = "http://hl7.org/fhir/permitted-data-type"
    };
  };
}
