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
  /// JSON Serialization Extensions for CoverageEligibilityResponse
  /// </summary>
  public static class CoverageEligibilityResponseJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR CoverageEligibilityResponse into JSON
    /// </summary>
    public static void SerializeJson(this CoverageEligibilityResponse current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","CoverageEligibilityResponse");
      // Complex: CoverageEligibilityResponse, Export: CoverageEligibilityResponse, Base: DomainResource (DomainResource)
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

      writer.WriteString("status",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.StatusElement.Value));

      if ((current.PurposeElement != null) && (current.PurposeElement.Count != 0))
      {
        writer.WritePropertyName("purpose");
        writer.WriteStartArray();
        foreach (Code<Hl7.Fhir.Model.CoverageEligibilityResponse.EligibilityResponsePurpose> val in current.PurposeElement)
        {
          writer.WriteStringValue(Hl7.Fhir.Utility.EnumUtility.GetLiteral(val.Value));
        }
        writer.WriteEndArray();
      }

      writer.WritePropertyName("patient");
      current.Patient.SerializeJson(writer, options);

      if (current.Serviced != null)
      {
        switch (current.Serviced)
        {
          case Date v_Date:
            writer.WriteString("servicedDate",v_Date.Value);
            break;
          case Period v_Period:
            writer.WritePropertyName("servicedPeriod");
            v_Period.SerializeJson(writer, options);
            break;
        }
      }
      writer.WriteString("created",current.CreatedElement.Value);

      if (current.Requestor != null)
      {
        writer.WritePropertyName("requestor");
        current.Requestor.SerializeJson(writer, options);
      }

      writer.WritePropertyName("request");
      current.Request.SerializeJson(writer, options);

      writer.WriteString("outcome",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.OutcomeElement.Value));

      if ((current.DispositionElement != null) && (current.DispositionElement.Value != null))
      {
        writer.WriteString("disposition",current.DispositionElement.Value);
      }

      writer.WritePropertyName("insurer");
      current.Insurer.SerializeJson(writer, options);

      if ((current.Insurance != null) && (current.Insurance.Count != 0))
      {
        writer.WritePropertyName("insurance");
        writer.WriteStartArray();
        foreach (CoverageEligibilityResponse.InsuranceComponent val in current.Insurance)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.PreAuthRefElement != null) && (current.PreAuthRefElement.Value != null))
      {
        writer.WriteString("preAuthRef",current.PreAuthRefElement.Value);
      }

      if (current.Form != null)
      {
        writer.WritePropertyName("form");
        current.Form.SerializeJson(writer, options);
      }

      if ((current.Error != null) && (current.Error.Count != 0))
      {
        writer.WritePropertyName("error");
        writer.WriteStartArray();
        foreach (CoverageEligibilityResponse.ErrorsComponent val in current.Error)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR CoverageEligibilityResponse
    /// </summary>
    public static void DeserializeJson(this CoverageEligibilityResponse current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR CoverageEligibilityResponse
    /// </summary>
    public static void DeserializeJsonProperty(this CoverageEligibilityResponse current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
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
          current.StatusElement =new Code<Hl7.Fhir.Model.FinancialResourceStatusCodes>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.FinancialResourceStatusCodes>(reader.GetString()));
          break;

        case "purpose":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.PurposeElement = new List<Code<Hl7.Fhir.Model.CoverageEligibilityResponse.EligibilityResponsePurpose>>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.PurposeElement.Add(new Code<Hl7.Fhir.Model.CoverageEligibilityResponse.EligibilityResponsePurpose>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.CoverageEligibilityResponse.EligibilityResponsePurpose>(reader.GetString())));

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.PurposeElement.Count == 0)
          {
            current.PurposeElement = null;
          }
          break;

        case "patient":
          current.Patient = new Hl7.Fhir.Model.ResourceReference();
          current.Patient.DeserializeJson(ref reader, options);
          break;

        case "servicedDate":
          current.Serviced = new Date(reader.GetString());
          break;

        case "servicedPeriod":
          current.Serviced = new Hl7.Fhir.Model.Period();
          current.Serviced.DeserializeJson(ref reader, options);
          break;

        case "created":
          current.CreatedElement = new FhirDateTime(reader.GetString());
          break;

        case "requestor":
          current.Requestor = new Hl7.Fhir.Model.ResourceReference();
          current.Requestor.DeserializeJson(ref reader, options);
          break;

        case "request":
          current.Request = new Hl7.Fhir.Model.ResourceReference();
          current.Request.DeserializeJson(ref reader, options);
          break;

        case "outcome":
          current.OutcomeElement =new Code<Hl7.Fhir.Model.ClaimProcessingCodes>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.ClaimProcessingCodes>(reader.GetString()));
          break;

        case "disposition":
          current.DispositionElement = new FhirString(reader.GetString());
          break;

        case "insurer":
          current.Insurer = new Hl7.Fhir.Model.ResourceReference();
          current.Insurer.DeserializeJson(ref reader, options);
          break;

        case "insurance":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Insurance = new List<CoverageEligibilityResponse.InsuranceComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CoverageEligibilityResponse.InsuranceComponent v_Insurance = new Hl7.Fhir.Model.CoverageEligibilityResponse.InsuranceComponent();
            v_Insurance.DeserializeJson(ref reader, options);
            current.Insurance.Add(v_Insurance);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Insurance.Count == 0)
          {
            current.Insurance = null;
          }
          break;

        case "preAuthRef":
          current.PreAuthRefElement = new FhirString(reader.GetString());
          break;

        case "form":
          current.Form = new Hl7.Fhir.Model.CodeableConcept();
          current.Form.DeserializeJson(ref reader, options);
          break;

        case "error":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Error = new List<CoverageEligibilityResponse.ErrorsComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CoverageEligibilityResponse.ErrorsComponent v_Error = new Hl7.Fhir.Model.CoverageEligibilityResponse.ErrorsComponent();
            v_Error.DeserializeJson(ref reader, options);
            current.Error.Add(v_Error);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Error.Count == 0)
          {
            current.Error = null;
          }
          break;

        // Complex: CoverageEligibilityResponse, Export: CoverageEligibilityResponse, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR CoverageEligibilityResponse#Insurance into JSON
    /// </summary>
    public static void SerializeJson(this CoverageEligibilityResponse.InsuranceComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: CoverageEligibilityResponse#Insurance, Export: InsuranceComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      writer.WritePropertyName("coverage");
      current.Coverage.SerializeJson(writer, options);

      if ((current.InforceElement != null) && (current.InforceElement.Value != null))
      {
        writer.WriteBoolean("inforce",(bool)current.InforceElement.Value);
      }

      if (current.BenefitPeriod != null)
      {
        writer.WritePropertyName("benefitPeriod");
        current.BenefitPeriod.SerializeJson(writer, options);
      }

      if ((current.Item != null) && (current.Item.Count != 0))
      {
        writer.WritePropertyName("item");
        writer.WriteStartArray();
        foreach (CoverageEligibilityResponse.ItemsComponent val in current.Item)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR CoverageEligibilityResponse#Insurance
    /// </summary>
    public static void DeserializeJson(this CoverageEligibilityResponse.InsuranceComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR CoverageEligibilityResponse#Insurance
    /// </summary>
    public static void DeserializeJsonProperty(this CoverageEligibilityResponse.InsuranceComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "coverage":
          current.Coverage = new Hl7.Fhir.Model.ResourceReference();
          current.Coverage.DeserializeJson(ref reader, options);
          break;

        case "inforce":
          current.InforceElement = new FhirBoolean(reader.GetBoolean());
          break;

        case "benefitPeriod":
          current.BenefitPeriod = new Hl7.Fhir.Model.Period();
          current.BenefitPeriod.DeserializeJson(ref reader, options);
          break;

        case "item":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Item = new List<CoverageEligibilityResponse.ItemsComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CoverageEligibilityResponse.ItemsComponent v_Item = new Hl7.Fhir.Model.CoverageEligibilityResponse.ItemsComponent();
            v_Item.DeserializeJson(ref reader, options);
            current.Item.Add(v_Item);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Item.Count == 0)
          {
            current.Item = null;
          }
          break;

        // Complex: insurance, Export: InsuranceComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR CoverageEligibilityResponse#Items into JSON
    /// </summary>
    public static void SerializeJson(this CoverageEligibilityResponse.ItemsComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: CoverageEligibilityResponse#Items, Export: ItemsComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if (current.Category != null)
      {
        writer.WritePropertyName("category");
        current.Category.SerializeJson(writer, options);
      }

      if (current.ProductOrService != null)
      {
        writer.WritePropertyName("productOrService");
        current.ProductOrService.SerializeJson(writer, options);
      }

      if ((current.Modifier != null) && (current.Modifier.Count != 0))
      {
        writer.WritePropertyName("modifier");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.Modifier)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.Provider != null)
      {
        writer.WritePropertyName("provider");
        current.Provider.SerializeJson(writer, options);
      }

      if ((current.ExcludedElement != null) && (current.ExcludedElement.Value != null))
      {
        writer.WriteBoolean("excluded",(bool)current.ExcludedElement.Value);
      }

      if ((current.NameElement != null) && (current.NameElement.Value != null))
      {
        writer.WriteString("name",current.NameElement.Value);
      }

      if ((current.DescriptionElement != null) && (current.DescriptionElement.Value != null))
      {
        writer.WriteString("description",current.DescriptionElement.Value);
      }

      if (current.Network != null)
      {
        writer.WritePropertyName("network");
        current.Network.SerializeJson(writer, options);
      }

      if (current.Unit != null)
      {
        writer.WritePropertyName("unit");
        current.Unit.SerializeJson(writer, options);
      }

      if (current.Term != null)
      {
        writer.WritePropertyName("term");
        current.Term.SerializeJson(writer, options);
      }

      if ((current.Benefit != null) && (current.Benefit.Count != 0))
      {
        writer.WritePropertyName("benefit");
        writer.WriteStartArray();
        foreach (CoverageEligibilityResponse.BenefitComponent val in current.Benefit)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.AuthorizationRequiredElement != null) && (current.AuthorizationRequiredElement.Value != null))
      {
        writer.WriteBoolean("authorizationRequired",(bool)current.AuthorizationRequiredElement.Value);
      }

      if ((current.AuthorizationSupporting != null) && (current.AuthorizationSupporting.Count != 0))
      {
        writer.WritePropertyName("authorizationSupporting");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.AuthorizationSupporting)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.AuthorizationUrlElement != null) && (current.AuthorizationUrlElement.Value != null))
      {
        writer.WriteString("authorizationUrl",current.AuthorizationUrlElement.Value);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR CoverageEligibilityResponse#Items
    /// </summary>
    public static void DeserializeJson(this CoverageEligibilityResponse.ItemsComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR CoverageEligibilityResponse#Items
    /// </summary>
    public static void DeserializeJsonProperty(this CoverageEligibilityResponse.ItemsComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "category":
          current.Category = new Hl7.Fhir.Model.CodeableConcept();
          current.Category.DeserializeJson(ref reader, options);
          break;

        case "productOrService":
          current.ProductOrService = new Hl7.Fhir.Model.CodeableConcept();
          current.ProductOrService.DeserializeJson(ref reader, options);
          break;

        case "modifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Modifier = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_Modifier = new Hl7.Fhir.Model.CodeableConcept();
            v_Modifier.DeserializeJson(ref reader, options);
            current.Modifier.Add(v_Modifier);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Modifier.Count == 0)
          {
            current.Modifier = null;
          }
          break;

        case "provider":
          current.Provider = new Hl7.Fhir.Model.ResourceReference();
          current.Provider.DeserializeJson(ref reader, options);
          break;

        case "excluded":
          current.ExcludedElement = new FhirBoolean(reader.GetBoolean());
          break;

        case "name":
          current.NameElement = new FhirString(reader.GetString());
          break;

        case "description":
          current.DescriptionElement = new FhirString(reader.GetString());
          break;

        case "network":
          current.Network = new Hl7.Fhir.Model.CodeableConcept();
          current.Network.DeserializeJson(ref reader, options);
          break;

        case "unit":
          current.Unit = new Hl7.Fhir.Model.CodeableConcept();
          current.Unit.DeserializeJson(ref reader, options);
          break;

        case "term":
          current.Term = new Hl7.Fhir.Model.CodeableConcept();
          current.Term.DeserializeJson(ref reader, options);
          break;

        case "benefit":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Benefit = new List<CoverageEligibilityResponse.BenefitComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CoverageEligibilityResponse.BenefitComponent v_Benefit = new Hl7.Fhir.Model.CoverageEligibilityResponse.BenefitComponent();
            v_Benefit.DeserializeJson(ref reader, options);
            current.Benefit.Add(v_Benefit);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Benefit.Count == 0)
          {
            current.Benefit = null;
          }
          break;

        case "authorizationRequired":
          current.AuthorizationRequiredElement = new FhirBoolean(reader.GetBoolean());
          break;

        case "authorizationSupporting":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.AuthorizationSupporting = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_AuthorizationSupporting = new Hl7.Fhir.Model.CodeableConcept();
            v_AuthorizationSupporting.DeserializeJson(ref reader, options);
            current.AuthorizationSupporting.Add(v_AuthorizationSupporting);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.AuthorizationSupporting.Count == 0)
          {
            current.AuthorizationSupporting = null;
          }
          break;

        case "authorizationUrl":
          current.AuthorizationUrlElement = new FhirUri(reader.GetString());
          break;

        // Complex: item, Export: ItemsComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR CoverageEligibilityResponse#Benefit into JSON
    /// </summary>
    public static void SerializeJson(this CoverageEligibilityResponse.BenefitComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: CoverageEligibilityResponse#Benefit, Export: BenefitComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      writer.WritePropertyName("type");
      current.Type.SerializeJson(writer, options);

      if (current.Allowed != null)
      {
        switch (current.Allowed)
        {
          case UnsignedInt v_UnsignedInt:
            writer.WriteNumber("allowedUnsignedInt",(int)v_UnsignedInt.Value);
            break;
          case FhirString v_FhirString:
            writer.WriteString("allowedString",v_FhirString.Value);
            break;
          case Money v_Money:
            writer.WritePropertyName("allowedMoney");
            v_Money.SerializeJson(writer, options);
            break;
        }
      }
      if (current.Used != null)
      {
        switch (current.Used)
        {
          case UnsignedInt v_UnsignedInt:
            writer.WriteNumber("usedUnsignedInt",(int)v_UnsignedInt.Value);
            break;
          case FhirString v_FhirString:
            writer.WriteString("usedString",v_FhirString.Value);
            break;
          case Money v_Money:
            writer.WritePropertyName("usedMoney");
            v_Money.SerializeJson(writer, options);
            break;
        }
      }
      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR CoverageEligibilityResponse#Benefit
    /// </summary>
    public static void DeserializeJson(this CoverageEligibilityResponse.BenefitComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR CoverageEligibilityResponse#Benefit
    /// </summary>
    public static void DeserializeJsonProperty(this CoverageEligibilityResponse.BenefitComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "type":
          current.Type = new Hl7.Fhir.Model.CodeableConcept();
          current.Type.DeserializeJson(ref reader, options);
          break;

        case "allowedUnsignedInt":
          current.Allowed = new UnsignedInt(reader.GetInt32());
          break;

        case "allowedString":
          current.Allowed = new FhirString(reader.GetString());
          break;

        case "allowedMoney":
          current.Allowed = new Hl7.Fhir.Model.Money();
          current.Allowed.DeserializeJson(ref reader, options);
          break;

        case "usedUnsignedInt":
          current.Used = new UnsignedInt(reader.GetInt32());
          break;

        case "usedString":
          current.Used = new FhirString(reader.GetString());
          break;

        case "usedMoney":
          current.Used = new Hl7.Fhir.Model.Money();
          current.Used.DeserializeJson(ref reader, options);
          break;

        // Complex: benefit, Export: BenefitComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR CoverageEligibilityResponse#Errors into JSON
    /// </summary>
    public static void SerializeJson(this CoverageEligibilityResponse.ErrorsComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: CoverageEligibilityResponse#Errors, Export: ErrorsComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      writer.WritePropertyName("code");
      current.Code.SerializeJson(writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR CoverageEligibilityResponse#Errors
    /// </summary>
    public static void DeserializeJson(this CoverageEligibilityResponse.ErrorsComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR CoverageEligibilityResponse#Errors
    /// </summary>
    public static void DeserializeJsonProperty(this CoverageEligibilityResponse.ErrorsComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "code":
          current.Code = new Hl7.Fhir.Model.CodeableConcept();
          current.Code.DeserializeJson(ref reader, options);
          break;

        // Complex: error, Export: ErrorsComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class CoverageEligibilityResponseJsonConverter : JsonConverter<CoverageEligibilityResponse>
    {
      /// <summary>
      /// Determines whether the specified type can be converted.
      /// </summary>
      public override bool CanConvert(Type objectType) =>
        typeof(CoverageEligibilityResponse).IsAssignableFrom(objectType);

      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, CoverageEligibilityResponse value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override CoverageEligibilityResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        CoverageEligibilityResponse target = new CoverageEligibilityResponse();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
