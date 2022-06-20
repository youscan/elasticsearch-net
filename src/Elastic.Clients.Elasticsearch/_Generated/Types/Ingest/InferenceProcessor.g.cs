// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Ingest
{
	public partial class InferenceProcessor : ProcessorBase, IProcessorVariant
	{
		[JsonInclude]
		[JsonPropertyName("field_map")]
		public Dictionary<Elastic.Clients.Elasticsearch.Field, object>? FieldMap { get; set; }

		[JsonInclude]
		[JsonPropertyName("inference_config")]
		public Elastic.Clients.Elasticsearch.Ingest.InferenceConfig? InferenceConfig { get; set; }

		[JsonInclude]
		[JsonPropertyName("model_id")]
		public Elastic.Clients.Elasticsearch.Id ModelId { get; set; }

		[JsonInclude]
		[JsonPropertyName("target_field")]
		public Elastic.Clients.Elasticsearch.Field TargetField { get; set; }
	}

	public sealed partial class InferenceProcessorDescriptor<TDocument> : SerializableDescriptorBase<InferenceProcessorDescriptor<TDocument>>
	{
		internal InferenceProcessorDescriptor(Action<InferenceProcessorDescriptor<TDocument>> configure) => configure.Invoke(this);
		public InferenceProcessorDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Ingest.InferenceConfig? InferenceConfigValue { get; set; }

		private InferenceConfigDescriptor<TDocument> InferenceConfigDescriptor { get; set; }

		private Action<InferenceConfigDescriptor<TDocument>> InferenceConfigDescriptorAction { get; set; }

		private IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? OnFailureValue { get; set; }

		private ProcessorContainerDescriptor<TDocument> OnFailureDescriptor { get; set; }

		private Action<ProcessorContainerDescriptor<TDocument>> OnFailureDescriptorAction { get; set; }

		private Action<ProcessorContainerDescriptor<TDocument>>[] OnFailureDescriptorActions { get; set; }

		private Dictionary<Elastic.Clients.Elasticsearch.Field, object>? FieldMapValue { get; set; }

		private string? IfValue { get; set; }

		private bool? IgnoreFailureValue { get; set; }

		private Elastic.Clients.Elasticsearch.Id ModelIdValue { get; set; }

		private string? TagValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field TargetFieldValue { get; set; }

		public InferenceProcessorDescriptor<TDocument> InferenceConfig(Elastic.Clients.Elasticsearch.Ingest.InferenceConfig? inferenceConfig)
		{
			InferenceConfigDescriptor = null;
			InferenceConfigDescriptorAction = null;
			InferenceConfigValue = inferenceConfig;
			return Self;
		}

		public InferenceProcessorDescriptor<TDocument> InferenceConfig(InferenceConfigDescriptor<TDocument> descriptor)
		{
			InferenceConfigValue = null;
			InferenceConfigDescriptorAction = null;
			InferenceConfigDescriptor = descriptor;
			return Self;
		}

		public InferenceProcessorDescriptor<TDocument> InferenceConfig(Action<InferenceConfigDescriptor<TDocument>> configure)
		{
			InferenceConfigValue = null;
			InferenceConfigDescriptor = null;
			InferenceConfigDescriptorAction = configure;
			return Self;
		}

		public InferenceProcessorDescriptor<TDocument> OnFailure(IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? onFailure)
		{
			OnFailureDescriptor = null;
			OnFailureDescriptorAction = null;
			OnFailureDescriptorActions = null;
			OnFailureValue = onFailure;
			return Self;
		}

		public InferenceProcessorDescriptor<TDocument> OnFailure(ProcessorContainerDescriptor<TDocument> descriptor)
		{
			OnFailureValue = null;
			OnFailureDescriptorAction = null;
			OnFailureDescriptorActions = null;
			OnFailureDescriptor = descriptor;
			return Self;
		}

		public InferenceProcessorDescriptor<TDocument> OnFailure(Action<ProcessorContainerDescriptor<TDocument>> configure)
		{
			OnFailureValue = null;
			OnFailureDescriptor = null;
			OnFailureDescriptorActions = null;
			OnFailureDescriptorAction = configure;
			return Self;
		}

		public InferenceProcessorDescriptor<TDocument> OnFailure(params Action<ProcessorContainerDescriptor<TDocument>>[] configure)
		{
			OnFailureValue = null;
			OnFailureDescriptor = null;
			OnFailureDescriptorAction = null;
			OnFailureDescriptorActions = configure;
			return Self;
		}

		public InferenceProcessorDescriptor<TDocument> FieldMap(Func<FluentDictionary<Elastic.Clients.Elasticsearch.Field, object>, FluentDictionary<Elastic.Clients.Elasticsearch.Field, object>> selector)
		{
			FieldMapValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.Field, object>());
			return Self;
		}

		public InferenceProcessorDescriptor<TDocument> If(string? ifValue)
		{
			IfValue = ifValue;
			return Self;
		}

		public InferenceProcessorDescriptor<TDocument> IgnoreFailure(bool? ignoreFailure = true)
		{
			IgnoreFailureValue = ignoreFailure;
			return Self;
		}

		public InferenceProcessorDescriptor<TDocument> ModelId(Elastic.Clients.Elasticsearch.Id modelId)
		{
			ModelIdValue = modelId;
			return Self;
		}

		public InferenceProcessorDescriptor<TDocument> Tag(string? tag)
		{
			TagValue = tag;
			return Self;
		}

		public InferenceProcessorDescriptor<TDocument> TargetField(Elastic.Clients.Elasticsearch.Field targetField)
		{
			TargetFieldValue = targetField;
			return Self;
		}

		public InferenceProcessorDescriptor<TDocument> TargetField<TValue>(Expression<Func<TDocument, TValue>> targetField)
		{
			TargetFieldValue = targetField;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (InferenceConfigDescriptor is not null)
			{
				writer.WritePropertyName("inference_config");
				JsonSerializer.Serialize(writer, InferenceConfigDescriptor, options);
			}
			else if (InferenceConfigDescriptorAction is not null)
			{
				writer.WritePropertyName("inference_config");
				JsonSerializer.Serialize(writer, new InferenceConfigDescriptor<TDocument>(InferenceConfigDescriptorAction), options);
			}
			else if (InferenceConfigValue is not null)
			{
				writer.WritePropertyName("inference_config");
				JsonSerializer.Serialize(writer, InferenceConfigValue, options);
			}

			if (OnFailureDescriptor is not null)
			{
				writer.WritePropertyName("on_failure");
				JsonSerializer.Serialize(writer, OnFailureDescriptor, options);
			}
			else if (OnFailureDescriptorAction is not null)
			{
				writer.WritePropertyName("on_failure");
				JsonSerializer.Serialize(writer, new ProcessorContainerDescriptor<TDocument>(OnFailureDescriptorAction), options);
			}
			else if (OnFailureDescriptorActions is not null)
			{
				writer.WritePropertyName("on_failure");
				writer.WriteStartArray();
				foreach (var action in OnFailureDescriptorActions)
				{
					JsonSerializer.Serialize(writer, new ProcessorContainerDescriptor<TDocument>(action), options);
				}

				writer.WriteEndArray();
			}
			else if (OnFailureValue is not null)
			{
				writer.WritePropertyName("on_failure");
				JsonSerializer.Serialize(writer, OnFailureValue, options);
			}

			if (FieldMapValue is not null)
			{
				writer.WritePropertyName("field_map");
				JsonSerializer.Serialize(writer, FieldMapValue, options);
			}

			if (!string.IsNullOrEmpty(IfValue))
			{
				writer.WritePropertyName("if");
				writer.WriteStringValue(IfValue);
			}

			if (IgnoreFailureValue.HasValue)
			{
				writer.WritePropertyName("ignore_failure");
				writer.WriteBooleanValue(IgnoreFailureValue.Value);
			}

			writer.WritePropertyName("model_id");
			JsonSerializer.Serialize(writer, ModelIdValue, options);
			if (!string.IsNullOrEmpty(TagValue))
			{
				writer.WritePropertyName("tag");
				writer.WriteStringValue(TagValue);
			}

			writer.WritePropertyName("target_field");
			JsonSerializer.Serialize(writer, TargetFieldValue, options);
			writer.WriteEndObject();
		}
	}

	public sealed partial class InferenceProcessorDescriptor : SerializableDescriptorBase<InferenceProcessorDescriptor>
	{
		internal InferenceProcessorDescriptor(Action<InferenceProcessorDescriptor> configure) => configure.Invoke(this);
		public InferenceProcessorDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Ingest.InferenceConfig? InferenceConfigValue { get; set; }

		private InferenceConfigDescriptor InferenceConfigDescriptor { get; set; }

		private Action<InferenceConfigDescriptor> InferenceConfigDescriptorAction { get; set; }

		private IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? OnFailureValue { get; set; }

		private ProcessorContainerDescriptor OnFailureDescriptor { get; set; }

		private Action<ProcessorContainerDescriptor> OnFailureDescriptorAction { get; set; }

		private Action<ProcessorContainerDescriptor>[] OnFailureDescriptorActions { get; set; }

		private Dictionary<Elastic.Clients.Elasticsearch.Field, object>? FieldMapValue { get; set; }

		private string? IfValue { get; set; }

		private bool? IgnoreFailureValue { get; set; }

		private Elastic.Clients.Elasticsearch.Id ModelIdValue { get; set; }

		private string? TagValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field TargetFieldValue { get; set; }

		public InferenceProcessorDescriptor InferenceConfig(Elastic.Clients.Elasticsearch.Ingest.InferenceConfig? inferenceConfig)
		{
			InferenceConfigDescriptor = null;
			InferenceConfigDescriptorAction = null;
			InferenceConfigValue = inferenceConfig;
			return Self;
		}

		public InferenceProcessorDescriptor InferenceConfig(InferenceConfigDescriptor descriptor)
		{
			InferenceConfigValue = null;
			InferenceConfigDescriptorAction = null;
			InferenceConfigDescriptor = descriptor;
			return Self;
		}

		public InferenceProcessorDescriptor InferenceConfig(Action<InferenceConfigDescriptor> configure)
		{
			InferenceConfigValue = null;
			InferenceConfigDescriptor = null;
			InferenceConfigDescriptorAction = configure;
			return Self;
		}

		public InferenceProcessorDescriptor OnFailure(IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? onFailure)
		{
			OnFailureDescriptor = null;
			OnFailureDescriptorAction = null;
			OnFailureDescriptorActions = null;
			OnFailureValue = onFailure;
			return Self;
		}

		public InferenceProcessorDescriptor OnFailure(ProcessorContainerDescriptor descriptor)
		{
			OnFailureValue = null;
			OnFailureDescriptorAction = null;
			OnFailureDescriptorActions = null;
			OnFailureDescriptor = descriptor;
			return Self;
		}

		public InferenceProcessorDescriptor OnFailure(Action<ProcessorContainerDescriptor> configure)
		{
			OnFailureValue = null;
			OnFailureDescriptor = null;
			OnFailureDescriptorActions = null;
			OnFailureDescriptorAction = configure;
			return Self;
		}

		public InferenceProcessorDescriptor OnFailure(params Action<ProcessorContainerDescriptor>[] configure)
		{
			OnFailureValue = null;
			OnFailureDescriptor = null;
			OnFailureDescriptorAction = null;
			OnFailureDescriptorActions = configure;
			return Self;
		}

		public InferenceProcessorDescriptor FieldMap(Func<FluentDictionary<Elastic.Clients.Elasticsearch.Field, object>, FluentDictionary<Elastic.Clients.Elasticsearch.Field, object>> selector)
		{
			FieldMapValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.Field, object>());
			return Self;
		}

		public InferenceProcessorDescriptor If(string? ifValue)
		{
			IfValue = ifValue;
			return Self;
		}

		public InferenceProcessorDescriptor IgnoreFailure(bool? ignoreFailure = true)
		{
			IgnoreFailureValue = ignoreFailure;
			return Self;
		}

		public InferenceProcessorDescriptor ModelId(Elastic.Clients.Elasticsearch.Id modelId)
		{
			ModelIdValue = modelId;
			return Self;
		}

		public InferenceProcessorDescriptor Tag(string? tag)
		{
			TagValue = tag;
			return Self;
		}

		public InferenceProcessorDescriptor TargetField(Elastic.Clients.Elasticsearch.Field targetField)
		{
			TargetFieldValue = targetField;
			return Self;
		}

		public InferenceProcessorDescriptor TargetField<TDocument, TValue>(Expression<Func<TDocument, TValue>> targetField)
		{
			TargetFieldValue = targetField;
			return Self;
		}

		public InferenceProcessorDescriptor TargetField<TDocument>(Expression<Func<TDocument, object>> targetField)
		{
			TargetFieldValue = targetField;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (InferenceConfigDescriptor is not null)
			{
				writer.WritePropertyName("inference_config");
				JsonSerializer.Serialize(writer, InferenceConfigDescriptor, options);
			}
			else if (InferenceConfigDescriptorAction is not null)
			{
				writer.WritePropertyName("inference_config");
				JsonSerializer.Serialize(writer, new InferenceConfigDescriptor(InferenceConfigDescriptorAction), options);
			}
			else if (InferenceConfigValue is not null)
			{
				writer.WritePropertyName("inference_config");
				JsonSerializer.Serialize(writer, InferenceConfigValue, options);
			}

			if (OnFailureDescriptor is not null)
			{
				writer.WritePropertyName("on_failure");
				JsonSerializer.Serialize(writer, OnFailureDescriptor, options);
			}
			else if (OnFailureDescriptorAction is not null)
			{
				writer.WritePropertyName("on_failure");
				JsonSerializer.Serialize(writer, new ProcessorContainerDescriptor(OnFailureDescriptorAction), options);
			}
			else if (OnFailureDescriptorActions is not null)
			{
				writer.WritePropertyName("on_failure");
				writer.WriteStartArray();
				foreach (var action in OnFailureDescriptorActions)
				{
					JsonSerializer.Serialize(writer, new ProcessorContainerDescriptor(action), options);
				}

				writer.WriteEndArray();
			}
			else if (OnFailureValue is not null)
			{
				writer.WritePropertyName("on_failure");
				JsonSerializer.Serialize(writer, OnFailureValue, options);
			}

			if (FieldMapValue is not null)
			{
				writer.WritePropertyName("field_map");
				JsonSerializer.Serialize(writer, FieldMapValue, options);
			}

			if (!string.IsNullOrEmpty(IfValue))
			{
				writer.WritePropertyName("if");
				writer.WriteStringValue(IfValue);
			}

			if (IgnoreFailureValue.HasValue)
			{
				writer.WritePropertyName("ignore_failure");
				writer.WriteBooleanValue(IgnoreFailureValue.Value);
			}

			writer.WritePropertyName("model_id");
			JsonSerializer.Serialize(writer, ModelIdValue, options);
			if (!string.IsNullOrEmpty(TagValue))
			{
				writer.WritePropertyName("tag");
				writer.WriteStringValue(TagValue);
			}

			writer.WritePropertyName("target_field");
			JsonSerializer.Serialize(writer, TargetFieldValue, options);
			writer.WriteEndObject();
		}
	}
}