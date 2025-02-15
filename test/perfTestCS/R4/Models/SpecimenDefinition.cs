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
  /// Substance introduced in the kind of container to preserve, maintain or enhance the specimen. Examples: Formalin, Citrate, EDTA.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonStreamComponentConverter<SpecimenDefinitionTypeTestedContainerAdditive>))]
  public class SpecimenDefinitionTypeTestedContainerAdditive : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Substance introduced in the kind of container to preserve, maintain or enhance the specimen. Examples: Formalin, Citrate, EDTA.
    /// </summary>
    public CodeableConcept AdditiveCodeableConcept { get; set; }
    /// <summary>
    /// Substance introduced in the kind of container to preserve, maintain or enhance the specimen. Examples: Formalin, Citrate, EDTA.
    /// </summary>
    public Reference AdditiveReference { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }

      ((Fhir.R4.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (AdditiveCodeableConcept != null)
      {
        writer.WritePropertyName("additiveCodeableConcept");
        AdditiveCodeableConcept.SerializeJson(writer, options);
      }

      if (AdditiveReference != null)
      {
        writer.WritePropertyName("additiveReference");
        AdditiveReference.SerializeJson(writer, options);
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
        case "additiveCodeableConcept":
          AdditiveCodeableConcept = new Fhir.R4.Models.CodeableConcept();
          AdditiveCodeableConcept.DeserializeJson(ref reader, options);
          break;

        case "additiveReference":
          AdditiveReference = new Fhir.R4.Models.Reference();
          AdditiveReference.DeserializeJson(ref reader, options);
          break;

        default:
          ((Fhir.R4.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// <summary>
  /// The specimen's container.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonStreamComponentConverter<SpecimenDefinitionTypeTestedContainer>))]
  public class SpecimenDefinitionTypeTestedContainer : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Substance introduced in the kind of container to preserve, maintain or enhance the specimen. Examples: Formalin, Citrate, EDTA.
    /// </summary>
    public List<SpecimenDefinitionTypeTestedContainerAdditive> Additive { get; set; }
    /// <summary>
    /// Color of container cap.
    /// </summary>
    public CodeableConcept Cap { get; set; }
    /// <summary>
    /// The capacity (volume or other measure) of this kind of container.
    /// </summary>
    public Quantity Capacity { get; set; }
    /// <summary>
    /// The textual description of the kind of container.
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Extension container element for Description
    /// </summary>
    public Element _Description { get; set; }
    /// <summary>
    /// The type of material of the container.
    /// </summary>
    public CodeableConcept Material { get; set; }
    /// <summary>
    /// The minimum volume to be conditioned in the container.
    /// </summary>
    public Quantity MinimumVolumeQuantity { get; set; }
    /// <summary>
    /// The minimum volume to be conditioned in the container.
    /// </summary>
    public string MinimumVolumeString { get; set; }
    /// <summary>
    /// Extension container element for MinimumVolumeString
    /// </summary>
    public Element _MinimumVolumeString { get; set; }
    /// <summary>
    /// Special processing that should be applied to the container for this kind of specimen.
    /// </summary>
    public string Preparation { get; set; }
    /// <summary>
    /// Extension container element for Preparation
    /// </summary>
    public Element _Preparation { get; set; }
    /// <summary>
    /// The type of container used to contain this kind of specimen.
    /// </summary>
    public CodeableConcept Type { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }

      ((Fhir.R4.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (Material != null)
      {
        writer.WritePropertyName("material");
        Material.SerializeJson(writer, options);
      }

      if (Type != null)
      {
        writer.WritePropertyName("type");
        Type.SerializeJson(writer, options);
      }

      if (Cap != null)
      {
        writer.WritePropertyName("cap");
        Cap.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Description))
      {
        writer.WriteString("description", (string)Description!);
      }

      if (_Description != null)
      {
        writer.WritePropertyName("_description");
        _Description.SerializeJson(writer, options);
      }

      if (Capacity != null)
      {
        writer.WritePropertyName("capacity");
        Capacity.SerializeJson(writer, options);
      }

      if (MinimumVolumeQuantity != null)
      {
        writer.WritePropertyName("minimumVolumeQuantity");
        MinimumVolumeQuantity.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(MinimumVolumeString))
      {
        writer.WriteString("minimumVolumeString", (string)MinimumVolumeString!);
      }

      if (_MinimumVolumeString != null)
      {
        writer.WritePropertyName("_minimumVolumeString");
        _MinimumVolumeString.SerializeJson(writer, options);
      }

      if ((Additive != null) && (Additive.Count != 0))
      {
        writer.WritePropertyName("additive");
        writer.WriteStartArray();

        foreach (SpecimenDefinitionTypeTestedContainerAdditive valAdditive in Additive)
        {
          valAdditive.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(Preparation))
      {
        writer.WriteString("preparation", (string)Preparation!);
      }

      if (_Preparation != null)
      {
        writer.WritePropertyName("_preparation");
        _Preparation.SerializeJson(writer, options);
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
        case "additive":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Additive = new List<SpecimenDefinitionTypeTestedContainerAdditive>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.SpecimenDefinitionTypeTestedContainerAdditive objAdditive = new Fhir.R4.Models.SpecimenDefinitionTypeTestedContainerAdditive();
            objAdditive.DeserializeJson(ref reader, options);
            Additive.Add(objAdditive);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Additive.Count == 0)
          {
            Additive = null;
          }

          break;

        case "cap":
          Cap = new Fhir.R4.Models.CodeableConcept();
          Cap.DeserializeJson(ref reader, options);
          break;

        case "capacity":
          Capacity = new Fhir.R4.Models.Quantity();
          Capacity.DeserializeJson(ref reader, options);
          break;

        case "description":
          Description = reader.GetString();
          break;

        case "_description":
          _Description = new Fhir.R4.Models.Element();
          _Description.DeserializeJson(ref reader, options);
          break;

        case "material":
          Material = new Fhir.R4.Models.CodeableConcept();
          Material.DeserializeJson(ref reader, options);
          break;

        case "minimumVolumeQuantity":
          MinimumVolumeQuantity = new Fhir.R4.Models.Quantity();
          MinimumVolumeQuantity.DeserializeJson(ref reader, options);
          break;

        case "minimumVolumeString":
          MinimumVolumeString = reader.GetString();
          break;

        case "_minimumVolumeString":
          _MinimumVolumeString = new Fhir.R4.Models.Element();
          _MinimumVolumeString.DeserializeJson(ref reader, options);
          break;

        case "preparation":
          Preparation = reader.GetString();
          break;

        case "_preparation":
          _Preparation = new Fhir.R4.Models.Element();
          _Preparation.DeserializeJson(ref reader, options);
          break;

        case "type":
          Type = new Fhir.R4.Models.CodeableConcept();
          Type.DeserializeJson(ref reader, options);
          break;

        default:
          ((Fhir.R4.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// <summary>
  /// Set of instructions for preservation/transport of the specimen at a defined temperature interval, prior the testing process.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonStreamComponentConverter<SpecimenDefinitionTypeTestedHandling>))]
  public class SpecimenDefinitionTypeTestedHandling : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Additional textual instructions for the preservation or transport of the specimen. For instance, 'Protect from light exposure'.
    /// </summary>
    public string Instruction { get; set; }
    /// <summary>
    /// Extension container element for Instruction
    /// </summary>
    public Element _Instruction { get; set; }
    /// <summary>
    /// The maximum time interval of preservation of the specimen with these conditions.
    /// </summary>
    public Duration MaxDuration { get; set; }
    /// <summary>
    /// It qualifies the interval of temperature, which characterizes an occurrence of handling. Conditions that are not related to temperature may be handled in the instruction element.
    /// </summary>
    public CodeableConcept TemperatureQualifier { get; set; }
    /// <summary>
    /// The temperature interval for this set of handling instructions.
    /// </summary>
    public Range TemperatureRange { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }

      ((Fhir.R4.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (TemperatureQualifier != null)
      {
        writer.WritePropertyName("temperatureQualifier");
        TemperatureQualifier.SerializeJson(writer, options);
      }

      if (TemperatureRange != null)
      {
        writer.WritePropertyName("temperatureRange");
        TemperatureRange.SerializeJson(writer, options);
      }

      if (MaxDuration != null)
      {
        writer.WritePropertyName("maxDuration");
        MaxDuration.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Instruction))
      {
        writer.WriteString("instruction", (string)Instruction!);
      }

      if (_Instruction != null)
      {
        writer.WritePropertyName("_instruction");
        _Instruction.SerializeJson(writer, options);
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
        case "instruction":
          Instruction = reader.GetString();
          break;

        case "_instruction":
          _Instruction = new Fhir.R4.Models.Element();
          _Instruction.DeserializeJson(ref reader, options);
          break;

        case "maxDuration":
          MaxDuration = new Fhir.R4.Models.Duration();
          MaxDuration.DeserializeJson(ref reader, options);
          break;

        case "temperatureQualifier":
          TemperatureQualifier = new Fhir.R4.Models.CodeableConcept();
          TemperatureQualifier.DeserializeJson(ref reader, options);
          break;

        case "temperatureRange":
          TemperatureRange = new Fhir.R4.Models.Range();
          TemperatureRange.DeserializeJson(ref reader, options);
          break;

        default:
          ((Fhir.R4.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// <summary>
  /// Specimen conditioned in a container as expected by the testing laboratory.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonStreamComponentConverter<SpecimenDefinitionTypeTested>))]
  public class SpecimenDefinitionTypeTested : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The specimen's container.
    /// </summary>
    public SpecimenDefinitionTypeTestedContainer Container { get; set; }
    /// <summary>
    /// Set of instructions for preservation/transport of the specimen at a defined temperature interval, prior the testing process.
    /// </summary>
    public List<SpecimenDefinitionTypeTestedHandling> Handling { get; set; }
    /// <summary>
    /// Primary of secondary specimen.
    /// </summary>
    public bool? IsDerived { get; set; }
    /// <summary>
    /// The preference for this type of conditioned specimen.
    /// </summary>
    public string Preference { get; set; }
    /// <summary>
    /// Extension container element for Preference
    /// </summary>
    public Element _Preference { get; set; }
    /// <summary>
    /// Criterion for rejection of the specimen in its container by the laboratory.
    /// </summary>
    public List<CodeableConcept> RejectionCriterion { get; set; }
    /// <summary>
    /// Requirements for delivery and special handling of this kind of conditioned specimen.
    /// </summary>
    public string Requirement { get; set; }
    /// <summary>
    /// Extension container element for Requirement
    /// </summary>
    public Element _Requirement { get; set; }
    /// <summary>
    /// The usual time that a specimen of this kind is retained after the ordered tests are completed, for the purpose of additional testing.
    /// </summary>
    public Duration RetentionTime { get; set; }
    /// <summary>
    /// The kind of specimen conditioned for testing expected by lab.
    /// </summary>
    public CodeableConcept Type { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }

      ((Fhir.R4.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (IsDerived != null)
      {
        writer.WriteBoolean("isDerived", (bool)IsDerived!);
      }

      if (Type != null)
      {
        writer.WritePropertyName("type");
        Type.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Preference))
      {
        writer.WriteString("preference", (string)Preference!);
      }

      if (_Preference != null)
      {
        writer.WritePropertyName("_preference");
        _Preference.SerializeJson(writer, options);
      }

      if (Container != null)
      {
        writer.WritePropertyName("container");
        Container.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Requirement))
      {
        writer.WriteString("requirement", (string)Requirement!);
      }

      if (_Requirement != null)
      {
        writer.WritePropertyName("_requirement");
        _Requirement.SerializeJson(writer, options);
      }

      if (RetentionTime != null)
      {
        writer.WritePropertyName("retentionTime");
        RetentionTime.SerializeJson(writer, options);
      }

      if ((RejectionCriterion != null) && (RejectionCriterion.Count != 0))
      {
        writer.WritePropertyName("rejectionCriterion");
        writer.WriteStartArray();

        foreach (CodeableConcept valRejectionCriterion in RejectionCriterion)
        {
          valRejectionCriterion.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Handling != null) && (Handling.Count != 0))
      {
        writer.WritePropertyName("handling");
        writer.WriteStartArray();

        foreach (SpecimenDefinitionTypeTestedHandling valHandling in Handling)
        {
          valHandling.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
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
        case "container":
          Container = new Fhir.R4.Models.SpecimenDefinitionTypeTestedContainer();
          Container.DeserializeJson(ref reader, options);
          break;

        case "handling":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Handling = new List<SpecimenDefinitionTypeTestedHandling>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.SpecimenDefinitionTypeTestedHandling objHandling = new Fhir.R4.Models.SpecimenDefinitionTypeTestedHandling();
            objHandling.DeserializeJson(ref reader, options);
            Handling.Add(objHandling);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Handling.Count == 0)
          {
            Handling = null;
          }

          break;

        case "isDerived":
          IsDerived = reader.GetBoolean();
          break;

        case "preference":
          Preference = reader.GetString();
          break;

        case "_preference":
          _Preference = new Fhir.R4.Models.Element();
          _Preference.DeserializeJson(ref reader, options);
          break;

        case "rejectionCriterion":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          RejectionCriterion = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.CodeableConcept objRejectionCriterion = new Fhir.R4.Models.CodeableConcept();
            objRejectionCriterion.DeserializeJson(ref reader, options);
            RejectionCriterion.Add(objRejectionCriterion);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (RejectionCriterion.Count == 0)
          {
            RejectionCriterion = null;
          }

          break;

        case "requirement":
          Requirement = reader.GetString();
          break;

        case "_requirement":
          _Requirement = new Fhir.R4.Models.Element();
          _Requirement.DeserializeJson(ref reader, options);
          break;

        case "retentionTime":
          RetentionTime = new Fhir.R4.Models.Duration();
          RetentionTime.DeserializeJson(ref reader, options);
          break;

        case "type":
          Type = new Fhir.R4.Models.CodeableConcept();
          Type.DeserializeJson(ref reader, options);
          break;

        default:
          ((Fhir.R4.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// <summary>
  /// A kind of specimen with associated set of requirements.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonStreamComponentConverter<SpecimenDefinition>))]
  public class SpecimenDefinition : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public string ResourceType => "SpecimenDefinition";
    /// <summary>
    /// The action to be performed for collecting the specimen.
    /// </summary>
    public List<CodeableConcept> Collection { get; set; }
    /// <summary>
    /// A business identifier associated with the kind of specimen.
    /// </summary>
    public Identifier Identifier { get; set; }
    /// <summary>
    /// Preparation of the patient for specimen collection.
    /// </summary>
    public List<CodeableConcept> PatientPreparation { get; set; }
    /// <summary>
    /// Time aspect of specimen collection (duration or offset).
    /// </summary>
    public string TimeAspect { get; set; }
    /// <summary>
    /// Extension container element for TimeAspect
    /// </summary>
    public Element _TimeAspect { get; set; }
    /// <summary>
    /// The kind of material to be collected.
    /// </summary>
    public CodeableConcept TypeCollected { get; set; }
    /// <summary>
    /// Specimen conditioned in a container as expected by the testing laboratory.
    /// </summary>
    public List<SpecimenDefinitionTypeTested> TypeTested { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }

      if (!string.IsNullOrEmpty(ResourceType))
      {
        writer.WriteString("resourceType", (string)ResourceType!);
      }


      ((Fhir.R4.Models.DomainResource)this).SerializeJson(writer, options, false);

      if (Identifier != null)
      {
        writer.WritePropertyName("identifier");
        Identifier.SerializeJson(writer, options);
      }

      if (TypeCollected != null)
      {
        writer.WritePropertyName("typeCollected");
        TypeCollected.SerializeJson(writer, options);
      }

      if ((PatientPreparation != null) && (PatientPreparation.Count != 0))
      {
        writer.WritePropertyName("patientPreparation");
        writer.WriteStartArray();

        foreach (CodeableConcept valPatientPreparation in PatientPreparation)
        {
          valPatientPreparation.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(TimeAspect))
      {
        writer.WriteString("timeAspect", (string)TimeAspect!);
      }

      if (_TimeAspect != null)
      {
        writer.WritePropertyName("_timeAspect");
        _TimeAspect.SerializeJson(writer, options);
      }

      if ((Collection != null) && (Collection.Count != 0))
      {
        writer.WritePropertyName("collection");
        writer.WriteStartArray();

        foreach (CodeableConcept valCollection in Collection)
        {
          valCollection.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((TypeTested != null) && (TypeTested.Count != 0))
      {
        writer.WritePropertyName("typeTested");
        writer.WriteStartArray();

        foreach (SpecimenDefinitionTypeTested valTypeTested in TypeTested)
        {
          valTypeTested.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
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
        case "collection":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Collection = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.CodeableConcept objCollection = new Fhir.R4.Models.CodeableConcept();
            objCollection.DeserializeJson(ref reader, options);
            Collection.Add(objCollection);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Collection.Count == 0)
          {
            Collection = null;
          }

          break;

        case "identifier":
          Identifier = new Fhir.R4.Models.Identifier();
          Identifier.DeserializeJson(ref reader, options);
          break;

        case "patientPreparation":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          PatientPreparation = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.CodeableConcept objPatientPreparation = new Fhir.R4.Models.CodeableConcept();
            objPatientPreparation.DeserializeJson(ref reader, options);
            PatientPreparation.Add(objPatientPreparation);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (PatientPreparation.Count == 0)
          {
            PatientPreparation = null;
          }

          break;

        case "timeAspect":
          TimeAspect = reader.GetString();
          break;

        case "_timeAspect":
          _TimeAspect = new Fhir.R4.Models.Element();
          _TimeAspect.DeserializeJson(ref reader, options);
          break;

        case "typeCollected":
          TypeCollected = new Fhir.R4.Models.CodeableConcept();
          TypeCollected.DeserializeJson(ref reader, options);
          break;

        case "typeTested":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          TypeTested = new List<SpecimenDefinitionTypeTested>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.SpecimenDefinitionTypeTested objTypeTested = new Fhir.R4.Models.SpecimenDefinitionTypeTested();
            objTypeTested.DeserializeJson(ref reader, options);
            TypeTested.Add(objTypeTested);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (TypeTested.Count == 0)
          {
            TypeTested = null;
          }

          break;

        default:
          ((Fhir.R4.Models.DomainResource)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
