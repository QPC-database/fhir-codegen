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
  /// JSON Serialization Extensions for SupplyRequest
  /// </summary>
  public static class SupplyRequestJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR SupplyRequest into JSON
    /// </summary>
    public static void SerializeJson(this SupplyRequest current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","SupplyRequest");
      // Complex: SupplyRequest, Export: SupplyRequest, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

      if ((current.Identifier != null) && (current.Identifier.Count != 0))
      {
        writer.WritePropertyName("identifier");
        writer.WriteStartArray();
        foreach (Identifier val in current.Identifier)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.StatusElement != null)
      {
        writer.WriteString("status",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.StatusElement.Value));
      }

      if (current.Category != null)
      {
        writer.WritePropertyName("category");
        current.Category.SerializeJson(writer, options);
      }

      if (current.PriorityElement != null)
      {
        writer.WriteString("priority",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.PriorityElement.Value));
      }

      if (current.Item != null)
      {
        switch (current.Item)
        {
          case CodeableConcept v_CodeableConcept:
            writer.WritePropertyName("itemCodeableConcept");
            v_CodeableConcept.SerializeJson(writer, options);
            break;
          case ResourceReference v_ResourceReference:
            writer.WritePropertyName("itemReference");
            v_ResourceReference.SerializeJson(writer, options);
            break;
        }
      }
      writer.WritePropertyName("quantity");
      current.Quantity.SerializeJson(writer, options);

      if ((current.Parameter != null) && (current.Parameter.Count != 0))
      {
        writer.WritePropertyName("parameter");
        writer.WriteStartArray();
        foreach (SupplyRequest.ParameterComponent val in current.Parameter)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.Occurrence != null)
      {
        switch (current.Occurrence)
        {
          case FhirDateTime v_FhirDateTime:
            writer.WriteString("occurrenceDateTime",v_FhirDateTime.Value);
            break;
          case Period v_Period:
            writer.WritePropertyName("occurrencePeriod");
            v_Period.SerializeJson(writer, options);
            break;
          case Timing v_Timing:
            writer.WritePropertyName("occurrenceTiming");
            v_Timing.SerializeJson(writer, options);
            break;
        }
      }
      if ((current.AuthoredOnElement != null) && (current.AuthoredOnElement.Value != null))
      {
        writer.WriteString("authoredOn",current.AuthoredOnElement.Value);
      }

      if (current.Requester != null)
      {
        writer.WritePropertyName("requester");
        current.Requester.SerializeJson(writer, options);
      }

      if ((current.Supplier != null) && (current.Supplier.Count != 0))
      {
        writer.WritePropertyName("supplier");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.Supplier)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.ReasonCode != null) && (current.ReasonCode.Count != 0))
      {
        writer.WritePropertyName("reasonCode");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.ReasonCode)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.ReasonReference != null) && (current.ReasonReference.Count != 0))
      {
        writer.WritePropertyName("reasonReference");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.ReasonReference)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.DeliverFrom != null)
      {
        writer.WritePropertyName("deliverFrom");
        current.DeliverFrom.SerializeJson(writer, options);
      }

      if (current.DeliverTo != null)
      {
        writer.WritePropertyName("deliverTo");
        current.DeliverTo.SerializeJson(writer, options);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR SupplyRequest
    /// </summary>
    public static void DeserializeJson(this SupplyRequest current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR SupplyRequest
    /// </summary>
    public static void DeserializeJsonProperty(this SupplyRequest current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Identifier v_Identifier = new Hl7.Fhir.Model.Identifier();
            v_Identifier.DeserializeJson(ref reader, options);
            current.Identifier.Add(v_Identifier);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Identifier.Count == 0)
          {
            current.Identifier = null;
          }
          break;

        case "status":
          current.StatusElement =new Code<Hl7.Fhir.Model.SupplyRequest.SupplyRequestStatus>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.SupplyRequest.SupplyRequestStatus>(reader.GetString()));
          break;

        case "category":
          current.Category = new Hl7.Fhir.Model.CodeableConcept();
          current.Category.DeserializeJson(ref reader, options);
          break;

        case "priority":
          current.PriorityElement =new Code<Hl7.Fhir.Model.RequestPriority>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.RequestPriority>(reader.GetString()));
          break;

        case "itemCodeableConcept":
          current.Item = new Hl7.Fhir.Model.CodeableConcept();
          current.Item.DeserializeJson(ref reader, options);
          break;

        case "itemReference":
          current.Item = new Hl7.Fhir.Model.ResourceReference();
          current.Item.DeserializeJson(ref reader, options);
          break;

        case "quantity":
          current.Quantity = new Hl7.Fhir.Model.Quantity();
          current.Quantity.DeserializeJson(ref reader, options);
          break;

        case "parameter":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Parameter = new List<SupplyRequest.ParameterComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.SupplyRequest.ParameterComponent v_Parameter = new Hl7.Fhir.Model.SupplyRequest.ParameterComponent();
            v_Parameter.DeserializeJson(ref reader, options);
            current.Parameter.Add(v_Parameter);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Parameter.Count == 0)
          {
            current.Parameter = null;
          }
          break;

        case "occurrenceDateTime":
          current.Occurrence = new FhirDateTime(reader.GetString());
          break;

        case "occurrencePeriod":
          current.Occurrence = new Hl7.Fhir.Model.Period();
          current.Occurrence.DeserializeJson(ref reader, options);
          break;

        case "occurrenceTiming":
          current.Occurrence = new Hl7.Fhir.Model.Timing();
          current.Occurrence.DeserializeJson(ref reader, options);
          break;

        case "authoredOn":
          current.AuthoredOnElement = new FhirDateTime(reader.GetString());
          break;

        case "requester":
          current.Requester = new Hl7.Fhir.Model.ResourceReference();
          current.Requester.DeserializeJson(ref reader, options);
          break;

        case "supplier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Supplier = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Supplier = new Hl7.Fhir.Model.ResourceReference();
            v_Supplier.DeserializeJson(ref reader, options);
            current.Supplier.Add(v_Supplier);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Supplier.Count == 0)
          {
            current.Supplier = null;
          }
          break;

        case "reasonCode":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.ReasonCode = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_ReasonCode = new Hl7.Fhir.Model.CodeableConcept();
            v_ReasonCode.DeserializeJson(ref reader, options);
            current.ReasonCode.Add(v_ReasonCode);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.ReasonCode.Count == 0)
          {
            current.ReasonCode = null;
          }
          break;

        case "reasonReference":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.ReasonReference = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_ReasonReference = new Hl7.Fhir.Model.ResourceReference();
            v_ReasonReference.DeserializeJson(ref reader, options);
            current.ReasonReference.Add(v_ReasonReference);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.ReasonReference.Count == 0)
          {
            current.ReasonReference = null;
          }
          break;

        case "deliverFrom":
          current.DeliverFrom = new Hl7.Fhir.Model.ResourceReference();
          current.DeliverFrom.DeserializeJson(ref reader, options);
          break;

        case "deliverTo":
          current.DeliverTo = new Hl7.Fhir.Model.ResourceReference();
          current.DeliverTo.DeserializeJson(ref reader, options);
          break;

        // Complex: SupplyRequest, Export: SupplyRequest, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR SupplyRequest#Parameter into JSON
    /// </summary>
    public static void SerializeJson(this SupplyRequest.ParameterComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: SupplyRequest#Parameter, Export: ParameterComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if (current.Code != null)
      {
        writer.WritePropertyName("code");
        current.Code.SerializeJson(writer, options);
      }

      if (current.Value != null)
      {
        switch (current.Value)
        {
          case CodeableConcept v_CodeableConcept:
            writer.WritePropertyName("valueCodeableConcept");
            v_CodeableConcept.SerializeJson(writer, options);
            break;
          case Quantity v_Quantity:
            writer.WritePropertyName("valueQuantity");
            v_Quantity.SerializeJson(writer, options);
            break;
          case Range v_Range:
            writer.WritePropertyName("valueRange");
            v_Range.SerializeJson(writer, options);
            break;
          case FhirBoolean v_FhirBoolean:
            writer.WriteBoolean("valueBoolean", (bool)v_FhirBoolean.Value);
            break;
        }
      }
      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR SupplyRequest#Parameter
    /// </summary>
    public static void DeserializeJson(this SupplyRequest.ParameterComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR SupplyRequest#Parameter
    /// </summary>
    public static void DeserializeJsonProperty(this SupplyRequest.ParameterComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "code":
          current.Code = new Hl7.Fhir.Model.CodeableConcept();
          current.Code.DeserializeJson(ref reader, options);
          break;

        case "valueCodeableConcept":
          current.Value = new Hl7.Fhir.Model.CodeableConcept();
          current.Value.DeserializeJson(ref reader, options);
          break;

        case "valueQuantity":
          current.Value = new Hl7.Fhir.Model.Quantity();
          current.Value.DeserializeJson(ref reader, options);
          break;

        case "valueRange":
          current.Value = new Hl7.Fhir.Model.Range();
          current.Value.DeserializeJson(ref reader, options);
          break;

        case "valueBoolean":
          current.Value = new FhirBoolean(reader.GetBoolean());
          break;

        // Complex: parameter, Export: ParameterComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class SupplyRequestJsonConverter : JsonConverter<SupplyRequest>
    {
      /// <summary>
      /// Determines whether the specified type can be converted.
      /// </summary>
      public override bool CanConvert(Type objectType) =>
        typeof(SupplyRequest).IsAssignableFrom(objectType);

      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, SupplyRequest value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override SupplyRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        SupplyRequest target = new SupplyRequest();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
