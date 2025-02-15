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
  /// JSON Serialization Extensions for Consent
  /// </summary>
  public static class ConsentJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR Consent into JSON
    /// </summary>
    public static void SerializeJson(this Consent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","Consent");
      // Complex: Consent, Export: Consent, Base: DomainResource (DomainResource)
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

      writer.WritePropertyName("scope");
      current.Scope.SerializeJson(writer, options);

      if ((current.Category != null) && (current.Category.Count != 0))
      {
        writer.WritePropertyName("category");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.Category)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.Patient != null)
      {
        writer.WritePropertyName("patient");
        current.Patient.SerializeJson(writer, options);
      }

      if ((current.DateTimeElement != null) && (current.DateTimeElement.Value != null))
      {
        writer.WriteString("dateTime",current.DateTimeElement.Value);
      }

      if ((current.Performer != null) && (current.Performer.Count != 0))
      {
        writer.WritePropertyName("performer");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.Performer)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Organization != null) && (current.Organization.Count != 0))
      {
        writer.WritePropertyName("organization");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.Organization)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.Source != null)
      {
        switch (current.Source)
        {
          case Attachment v_Attachment:
            writer.WritePropertyName("sourceAttachment");
            v_Attachment.SerializeJson(writer, options);
            break;
          case ResourceReference v_ResourceReference:
            writer.WritePropertyName("sourceReference");
            v_ResourceReference.SerializeJson(writer, options);
            break;
        }
      }
      if ((current.Policy != null) && (current.Policy.Count != 0))
      {
        writer.WritePropertyName("policy");
        writer.WriteStartArray();
        foreach (Consent.PolicyComponent val in current.Policy)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.PolicyRule != null)
      {
        writer.WritePropertyName("policyRule");
        current.PolicyRule.SerializeJson(writer, options);
      }

      if ((current.Verification != null) && (current.Verification.Count != 0))
      {
        writer.WritePropertyName("verification");
        writer.WriteStartArray();
        foreach (Consent.VerificationComponent val in current.Verification)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.Provision != null)
      {
        writer.WritePropertyName("provision");
        current.Provision.SerializeJson(writer, options);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Consent
    /// </summary>
    public static void DeserializeJson(this Consent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR Consent
    /// </summary>
    public static void DeserializeJsonProperty(this Consent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
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
          current.StatusElement =new Code<Hl7.Fhir.Model.Consent.ConsentState>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.Consent.ConsentState>(reader.GetString()));
          break;

        case "scope":
          current.Scope = new Hl7.Fhir.Model.CodeableConcept();
          current.Scope.DeserializeJson(ref reader, options);
          break;

        case "category":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Category = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_Category = new Hl7.Fhir.Model.CodeableConcept();
            v_Category.DeserializeJson(ref reader, options);
            current.Category.Add(v_Category);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Category.Count == 0)
          {
            current.Category = null;
          }
          break;

        case "patient":
          current.Patient = new Hl7.Fhir.Model.ResourceReference();
          current.Patient.DeserializeJson(ref reader, options);
          break;

        case "dateTime":
          current.DateTimeElement = new FhirDateTime(reader.GetString());
          break;

        case "performer":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Performer = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Performer = new Hl7.Fhir.Model.ResourceReference();
            v_Performer.DeserializeJson(ref reader, options);
            current.Performer.Add(v_Performer);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Performer.Count == 0)
          {
            current.Performer = null;
          }
          break;

        case "organization":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Organization = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Organization = new Hl7.Fhir.Model.ResourceReference();
            v_Organization.DeserializeJson(ref reader, options);
            current.Organization.Add(v_Organization);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Organization.Count == 0)
          {
            current.Organization = null;
          }
          break;

        case "sourceAttachment":
          current.Source = new Hl7.Fhir.Model.Attachment();
          current.Source.DeserializeJson(ref reader, options);
          break;

        case "sourceReference":
          current.Source = new Hl7.Fhir.Model.ResourceReference();
          current.Source.DeserializeJson(ref reader, options);
          break;

        case "policy":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Policy = new List<Consent.PolicyComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Consent.PolicyComponent v_Policy = new Hl7.Fhir.Model.Consent.PolicyComponent();
            v_Policy.DeserializeJson(ref reader, options);
            current.Policy.Add(v_Policy);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Policy.Count == 0)
          {
            current.Policy = null;
          }
          break;

        case "policyRule":
          current.PolicyRule = new Hl7.Fhir.Model.CodeableConcept();
          current.PolicyRule.DeserializeJson(ref reader, options);
          break;

        case "verification":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Verification = new List<Consent.VerificationComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Consent.VerificationComponent v_Verification = new Hl7.Fhir.Model.Consent.VerificationComponent();
            v_Verification.DeserializeJson(ref reader, options);
            current.Verification.Add(v_Verification);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Verification.Count == 0)
          {
            current.Verification = null;
          }
          break;

        case "provision":
          current.Provision = new Hl7.Fhir.Model.Consent.provisionComponent();
          current.Provision.DeserializeJson(ref reader, options);
          break;

        // Complex: Consent, Export: Consent, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR Consent#Policy into JSON
    /// </summary>
    public static void SerializeJson(this Consent.PolicyComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: Consent#Policy, Export: PolicyComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if ((current.AuthorityElement != null) && (current.AuthorityElement.Value != null))
      {
        writer.WriteString("authority",current.AuthorityElement.Value);
      }

      if ((current.UriElement != null) && (current.UriElement.Value != null))
      {
        writer.WriteString("uri",current.UriElement.Value);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Consent#Policy
    /// </summary>
    public static void DeserializeJson(this Consent.PolicyComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR Consent#Policy
    /// </summary>
    public static void DeserializeJsonProperty(this Consent.PolicyComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "authority":
          current.AuthorityElement = new FhirUri(reader.GetString());
          break;

        case "uri":
          current.UriElement = new FhirUri(reader.GetString());
          break;

        // Complex: policy, Export: PolicyComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR Consent#Verification into JSON
    /// </summary>
    public static void SerializeJson(this Consent.VerificationComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: Consent#Verification, Export: VerificationComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      writer.WriteBoolean("verified",(bool)current.VerifiedElement.Value);

      if (current.VerifiedWith != null)
      {
        writer.WritePropertyName("verifiedWith");
        current.VerifiedWith.SerializeJson(writer, options);
      }

      if ((current.VerificationDateElement != null) && (current.VerificationDateElement.Value != null))
      {
        writer.WriteString("verificationDate",current.VerificationDateElement.Value);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Consent#Verification
    /// </summary>
    public static void DeserializeJson(this Consent.VerificationComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR Consent#Verification
    /// </summary>
    public static void DeserializeJsonProperty(this Consent.VerificationComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "verified":
          current.VerifiedElement = new FhirBoolean(reader.GetBoolean());
          break;

        case "verifiedWith":
          current.VerifiedWith = new Hl7.Fhir.Model.ResourceReference();
          current.VerifiedWith.DeserializeJson(ref reader, options);
          break;

        case "verificationDate":
          current.VerificationDateElement = new FhirDateTime(reader.GetString());
          break;

        // Complex: verification, Export: VerificationComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR Consent#provision into JSON
    /// </summary>
    public static void SerializeJson(this Consent.provisionComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: Consent#provision, Export: provisionComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if (current.TypeElement != null)
      {
        writer.WriteString("type",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.TypeElement.Value));
      }

      if (current.Period != null)
      {
        writer.WritePropertyName("period");
        current.Period.SerializeJson(writer, options);
      }

      if ((current.Actor != null) && (current.Actor.Count != 0))
      {
        writer.WritePropertyName("actor");
        writer.WriteStartArray();
        foreach (Consent.provisionActorComponent val in current.Actor)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Action != null) && (current.Action.Count != 0))
      {
        writer.WritePropertyName("action");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.Action)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.SecurityLabel != null) && (current.SecurityLabel.Count != 0))
      {
        writer.WritePropertyName("securityLabel");
        writer.WriteStartArray();
        foreach (Coding val in current.SecurityLabel)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Purpose != null) && (current.Purpose.Count != 0))
      {
        writer.WritePropertyName("purpose");
        writer.WriteStartArray();
        foreach (Coding val in current.Purpose)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Class != null) && (current.Class.Count != 0))
      {
        writer.WritePropertyName("class");
        writer.WriteStartArray();
        foreach (Coding val in current.Class)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Code != null) && (current.Code.Count != 0))
      {
        writer.WritePropertyName("code");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.Code)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.DataPeriod != null)
      {
        writer.WritePropertyName("dataPeriod");
        current.DataPeriod.SerializeJson(writer, options);
      }

      if ((current.Data != null) && (current.Data.Count != 0))
      {
        writer.WritePropertyName("data");
        writer.WriteStartArray();
        foreach (Consent.provisionDataComponent val in current.Data)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Provision != null) && (current.Provision.Count != 0))
      {
        writer.WritePropertyName("provision");
        writer.WriteStartArray();
        foreach (Consent.provisionComponent val in current.Provision)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Consent#provision
    /// </summary>
    public static void DeserializeJson(this Consent.provisionComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR Consent#provision
    /// </summary>
    public static void DeserializeJsonProperty(this Consent.provisionComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "type":
          current.TypeElement =new Code<Hl7.Fhir.Model.Consent.ConsentProvisionType>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.Consent.ConsentProvisionType>(reader.GetString()));
          break;

        case "period":
          current.Period = new Hl7.Fhir.Model.Period();
          current.Period.DeserializeJson(ref reader, options);
          break;

        case "actor":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Actor = new List<Consent.provisionActorComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Consent.provisionActorComponent v_Actor = new Hl7.Fhir.Model.Consent.provisionActorComponent();
            v_Actor.DeserializeJson(ref reader, options);
            current.Actor.Add(v_Actor);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Actor.Count == 0)
          {
            current.Actor = null;
          }
          break;

        case "action":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Action = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_Action = new Hl7.Fhir.Model.CodeableConcept();
            v_Action.DeserializeJson(ref reader, options);
            current.Action.Add(v_Action);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Action.Count == 0)
          {
            current.Action = null;
          }
          break;

        case "securityLabel":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.SecurityLabel = new List<Coding>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Coding v_SecurityLabel = new Hl7.Fhir.Model.Coding();
            v_SecurityLabel.DeserializeJson(ref reader, options);
            current.SecurityLabel.Add(v_SecurityLabel);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.SecurityLabel.Count == 0)
          {
            current.SecurityLabel = null;
          }
          break;

        case "purpose":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Purpose = new List<Coding>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Coding v_Purpose = new Hl7.Fhir.Model.Coding();
            v_Purpose.DeserializeJson(ref reader, options);
            current.Purpose.Add(v_Purpose);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Purpose.Count == 0)
          {
            current.Purpose = null;
          }
          break;

        case "class":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Class = new List<Coding>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Coding v_Class = new Hl7.Fhir.Model.Coding();
            v_Class.DeserializeJson(ref reader, options);
            current.Class.Add(v_Class);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Class.Count == 0)
          {
            current.Class = null;
          }
          break;

        case "code":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Code = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_Code = new Hl7.Fhir.Model.CodeableConcept();
            v_Code.DeserializeJson(ref reader, options);
            current.Code.Add(v_Code);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Code.Count == 0)
          {
            current.Code = null;
          }
          break;

        case "dataPeriod":
          current.DataPeriod = new Hl7.Fhir.Model.Period();
          current.DataPeriod.DeserializeJson(ref reader, options);
          break;

        case "data":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Data = new List<Consent.provisionDataComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Consent.provisionDataComponent v_Data = new Hl7.Fhir.Model.Consent.provisionDataComponent();
            v_Data.DeserializeJson(ref reader, options);
            current.Data.Add(v_Data);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Data.Count == 0)
          {
            current.Data = null;
          }
          break;

        case "provision":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Provision = new List<Consent.provisionComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Consent.provisionComponent v_Provision = new Hl7.Fhir.Model.Consent.provisionComponent();
            v_Provision.DeserializeJson(ref reader, options);
            current.Provision.Add(v_Provision);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Provision.Count == 0)
          {
            current.Provision = null;
          }
          break;

        // Complex: provision, Export: provisionComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR Consent#provisionActor into JSON
    /// </summary>
    public static void SerializeJson(this Consent.provisionActorComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: Consent#provisionActor, Export: provisionActorComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      writer.WritePropertyName("role");
      current.Role.SerializeJson(writer, options);

      writer.WritePropertyName("reference");
      current.Reference.SerializeJson(writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Consent#provisionActor
    /// </summary>
    public static void DeserializeJson(this Consent.provisionActorComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR Consent#provisionActor
    /// </summary>
    public static void DeserializeJsonProperty(this Consent.provisionActorComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "role":
          current.Role = new Hl7.Fhir.Model.CodeableConcept();
          current.Role.DeserializeJson(ref reader, options);
          break;

        case "reference":
          current.Reference = new Hl7.Fhir.Model.ResourceReference();
          current.Reference.DeserializeJson(ref reader, options);
          break;

        // Complex: actor, Export: provisionActorComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR Consent#provisionData into JSON
    /// </summary>
    public static void SerializeJson(this Consent.provisionDataComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: Consent#provisionData, Export: provisionDataComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      writer.WriteString("meaning",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.MeaningElement.Value));

      writer.WritePropertyName("reference");
      current.Reference.SerializeJson(writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Consent#provisionData
    /// </summary>
    public static void DeserializeJson(this Consent.provisionDataComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
    /// Deserialize JSON into a FHIR Consent#provisionData
    /// </summary>
    public static void DeserializeJsonProperty(this Consent.provisionDataComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "meaning":
          current.MeaningElement =new Code<Hl7.Fhir.Model.Consent.ConsentDataMeaning>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.Consent.ConsentDataMeaning>(reader.GetString()));
          break;

        case "reference":
          current.Reference = new Hl7.Fhir.Model.ResourceReference();
          current.Reference.DeserializeJson(ref reader, options);
          break;

        // Complex: data, Export: provisionDataComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class ConsentJsonConverter : JsonConverter<Consent>
    {
      /// <summary>
      /// Determines whether the specified type can be converted.
      /// </summary>
      public override bool CanConvert(Type objectType) =>
        typeof(Consent).IsAssignableFrom(objectType);

      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, Consent value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override Consent Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        Consent target = new Consent();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
