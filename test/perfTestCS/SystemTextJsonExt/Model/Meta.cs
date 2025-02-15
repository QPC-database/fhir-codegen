// <auto-generated/>
// Contents of: hl7.fhir.r4.core version: 4.0.1

using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Hl7.Fhir.Model;
using Hl7.Fhir.Model.JsonExtensions;
using Hl7.Fhir.Serialization;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  
*/

namespace Hl7.Fhir.Model.JsonExtensions
{
  /// <summary>
  /// JSON Serialization Extensions for Meta
  /// </summary>
  public static class MetaJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR Meta into JSON
    /// </summary>
    public static void SerializeJson(this Meta current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      if ((current.VersionIdElement != null) && (current.VersionIdElement.Value != null))
      {
        writer.WriteString("versionId",current.VersionIdElement.Value);
      }

      if ((current.LastUpdatedElement != null) && (current.LastUpdatedElement.Value != null))
      {
        writer.WriteString("lastUpdated",((DateTimeOffset)current.LastUpdatedElement.Value).ToString("yyyy-MM-dd'T'HH:mm:ss.FFFFFFFK", System.Globalization.CultureInfo.InvariantCulture));
      }

      if ((current.SourceElement != null) && (current.SourceElement.Value != null))
      {
        writer.WriteString("source",current.SourceElement.Value);
      }

      if ((current.ProfileElement != null) && (current.ProfileElement.Count != 0))
      {
        writer.WritePropertyName("profile");
        writer.WriteStartArray();
        foreach (FhirUri val in current.ProfileElement)
        {
          writer.WriteStringValue(val.Value);
        }
        writer.WriteEndArray();
      }

      if ((current.Security != null) && (current.Security.Count != 0))
      {
        writer.WritePropertyName("security");
        writer.WriteStartArray();
        foreach (Coding val in current.Security)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Tag != null) && (current.Tag.Count != 0))
      {
        writer.WritePropertyName("tag");
        writer.WriteStartArray();
        foreach (Coding val in current.Tag)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Meta
    /// </summary>
    public static void DeserializeJson(this Meta current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Meta
    /// </summary>
    public static void DeserializeJsonProperty(this Meta current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "versionId":
          current.VersionIdElement = new Id(reader.GetString());
          break;

        case "_versionId":
          ((Hl7.Fhir.Model.Element)current.VersionIdElement).DeserializeJson(ref reader, options);
          break;

        case "lastUpdated":
          current.LastUpdatedElement = new Instant(DateTimeOffset.Parse(reader.GetString()));
          break;

        case "_lastUpdated":
          ((Hl7.Fhir.Model.Element)current.LastUpdatedElement).DeserializeJson(ref reader, options);
          break;

        case "source":
          current.SourceElement = new FhirUri(reader.GetString());
          break;

        case "profile":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.ProfileElement = new List<FhirUri>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.ProfileElement.Add(new FhirUri(reader.GetString()));

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.ProfileElement.Count == 0)
          {
            current.ProfileElement = null;
          }
          break;

        case "security":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Security = new List<Coding>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Coding v_Security = new Hl7.Fhir.Model.Coding();
            v_Security.DeserializeJson(ref reader, options);
            current.Security.Add(v_Security);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Security.Count == 0)
          {
            current.Security = null;
          }
          break;

        case "tag":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Tag = new List<Coding>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Coding v_Tag = new Hl7.Fhir.Model.Coding();
            v_Tag.DeserializeJson(ref reader, options);
            current.Tag.Add(v_Tag);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Tag.Count == 0)
          {
            current.Tag = null;
          }
          break;

      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class MetaJsonConverter : JsonConverter<Meta>
    {
      /// <summary>
      /// Determines whether the specified type can be converted.
      /// </summary>
      public override bool CanConvert(Type objectType) =>
        typeof(Meta).IsAssignableFrom(objectType);

      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, Meta value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override Meta Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        Meta target = new Meta();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
