// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Fhir.R4.Serialization;

namespace Fhir.R4.Models
{
  /// <summary>
  /// The parameters to the module. This collection specifies both the input and output parameters. Input parameters are provided by the caller as part of the $evaluate operation. Output parameters are included in the GuidanceResponse.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonStreamComponentConverter<ParameterDefinition>))]
  public class ParameterDefinition : Element,  IFhirJsonSerializable {
    /// <summary>
    /// A brief discussion of what the parameter is for and how it is used by the module.
    /// </summary>
    public string Documentation { get; set; }
    /// <summary>
    /// Extension container element for Documentation
    /// </summary>
    public Element _Documentation { get; set; }
    /// <summary>
    /// The maximum number of times this element is permitted to appear in the request or response.
    /// </summary>
    public string Max { get; set; }
    /// <summary>
    /// Extension container element for Max
    /// </summary>
    public Element _Max { get; set; }
    /// <summary>
    /// The minimum number of times this parameter SHALL appear in the request or response.
    /// </summary>
    public int? Min { get; set; }
    /// <summary>
    /// The name of the parameter used to allow access to the value of the parameter in evaluation contexts.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Extension container element for Name
    /// </summary>
    public Element _Name { get; set; }
    /// <summary>
    /// If specified, this indicates a profile that the input data must conform to, or that the output data will conform to.
    /// </summary>
    public string Profile { get; set; }
    /// <summary>
    /// Extension container element for Profile
    /// </summary>
    public Element _Profile { get; set; }
    /// <summary>
    /// The type of the parameter.
    /// </summary>
    public string Type { get; set; }
    /// <summary>
    /// Extension container element for Type
    /// </summary>
    public Element _Type { get; set; }
    /// <summary>
    /// Whether the parameter is input or output for the module.
    /// </summary>
    public string Use { get; set; }
    /// <summary>
    /// Extension container element for Use
    /// </summary>
    public Element _Use { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }

      ((Fhir.R4.Models.Element)this).SerializeJson(writer, options, false);

      if (!string.IsNullOrEmpty(Name))
      {
        writer.WriteString("name", (string)Name!);
      }

      if (_Name != null)
      {
        writer.WritePropertyName("_name");
        _Name.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Use))
      {
        writer.WriteString("use", (string)Use!);
      }

      if (_Use != null)
      {
        writer.WritePropertyName("_use");
        _Use.SerializeJson(writer, options);
      }

      if (Min != null)
      {
        writer.WriteNumber("min", (int)Min!);
      }

      if (!string.IsNullOrEmpty(Max))
      {
        writer.WriteString("max", (string)Max!);
      }

      if (_Max != null)
      {
        writer.WritePropertyName("_max");
        _Max.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Documentation))
      {
        writer.WriteString("documentation", (string)Documentation!);
      }

      if (_Documentation != null)
      {
        writer.WritePropertyName("_documentation");
        _Documentation.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Type))
      {
        writer.WriteString("type", (string)Type!);
      }

      if (_Type != null)
      {
        writer.WritePropertyName("_type");
        _Type.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Profile))
      {
        writer.WriteString("profile", (string)Profile!);
      }

      if (_Profile != null)
      {
        writer.WritePropertyName("_profile");
        _Profile.SerializeJson(writer, options);
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "documentation":
          Documentation = reader.GetString();
          break;

        case "_documentation":
          _Documentation = new Fhir.R4.Models.Element();
          _Documentation.DeserializeJson(ref reader, options);
          break;

        case "max":
          Max = reader.GetString();
          break;

        case "_max":
          _Max = new Fhir.R4.Models.Element();
          _Max.DeserializeJson(ref reader, options);
          break;

        case "min":
          Min = reader.GetInt32();
          break;

        case "name":
          Name = reader.GetString();
          break;

        case "_name":
          _Name = new Fhir.R4.Models.Element();
          _Name.DeserializeJson(ref reader, options);
          break;

        case "profile":
          Profile = reader.GetString();
          break;

        case "_profile":
          _Profile = new Fhir.R4.Models.Element();
          _Profile.DeserializeJson(ref reader, options);
          break;

        case "type":
          Type = reader.GetString();
          break;

        case "_type":
          _Type = new Fhir.R4.Models.Element();
          _Type.DeserializeJson(ref reader, options);
          break;

        case "use":
          Use = reader.GetString();
          break;

        case "_use":
          _Use = new Fhir.R4.Models.Element();
          _Use.DeserializeJson(ref reader, options);
          break;

        default:
          ((Fhir.R4.Models.Element)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
}
