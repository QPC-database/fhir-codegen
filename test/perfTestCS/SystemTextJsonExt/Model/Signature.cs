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
  /// JSON Serialization Extensions for Signature
  /// </summary>
  public static class SignatureJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR Signature into JSON
    /// </summary>
    public static void SerializeJson(this Signature current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      if ((current.Type != null) && (current.Type.Count != 0))
      {
        writer.WritePropertyName("type");
        writer.WriteStartArray();
        foreach (Coding val in current.Type)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      writer.WriteString("when",((DateTimeOffset)current.WhenElement.Value).ToString("yyyy-MM-dd'T'HH:mm:ss.FFFFFFFK", System.Globalization.CultureInfo.InvariantCulture));

      writer.WritePropertyName("who");
      current.Who.SerializeJson(writer, options);

      if (current.OnBehalfOf != null)
      {
        writer.WritePropertyName("onBehalfOf");
        current.OnBehalfOf.SerializeJson(writer, options);
      }

      if ((current.TargetFormatElement != null) && (current.TargetFormatElement.Value != null))
      {
        writer.WriteString("targetFormat",current.TargetFormatElement.Value);
      }

      if ((current.SigFormatElement != null) && (current.SigFormatElement.Value != null))
      {
        writer.WriteString("sigFormat",current.SigFormatElement.Value);
      }

      if ((current.DataElement != null) && (current.DataElement.Value != null))
      {
        writer.WriteBase64String("data",current.DataElement.Value);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Signature
    /// </summary>
    public static void DeserializeJson(this Signature current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR Signature
    /// </summary>
    public static void DeserializeJsonProperty(this Signature current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "type":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Type = new List<Coding>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Coding v_Type = new Hl7.Fhir.Model.Coding();
            v_Type.DeserializeJson(ref reader, options);
            current.Type.Add(v_Type);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Type.Count == 0)
          {
            current.Type = null;
          }
          break;

        case "when":
          current.WhenElement = new Instant(DateTimeOffset.Parse(reader.GetString()));
          break;

        case "_when":
          ((Hl7.Fhir.Model.Element)current.WhenElement).DeserializeJson(ref reader, options);
          break;

        case "who":
          current.Who = new Hl7.Fhir.Model.ResourceReference();
          current.Who.DeserializeJson(ref reader, options);
          break;

        case "onBehalfOf":
          current.OnBehalfOf = new Hl7.Fhir.Model.ResourceReference();
          current.OnBehalfOf.DeserializeJson(ref reader, options);
          break;

        case "targetFormat":
          current.TargetFormatElement = new Code(reader.GetString());
          break;

        case "_targetFormat":
          ((Hl7.Fhir.Model.Element)current.TargetFormatElement).DeserializeJson(ref reader, options);
          break;

        case "sigFormat":
          current.SigFormatElement = new Code(reader.GetString());
          break;

        case "_sigFormat":
          ((Hl7.Fhir.Model.Element)current.SigFormatElement).DeserializeJson(ref reader, options);
          break;

        case "data":
          current.DataElement = new Base64Binary(reader.GetBytesFromBase64());
          break;

      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class SignatureJsonConverter : JsonConverter<Signature>
    {
      /// <summary>
      /// Determines whether the specified type can be converted.
      /// </summary>
      public override bool CanConvert(Type objectType) =>
        typeof(Signature).IsAssignableFrom(objectType);

      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, Signature value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override Signature Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        Signature target = new Signature();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
