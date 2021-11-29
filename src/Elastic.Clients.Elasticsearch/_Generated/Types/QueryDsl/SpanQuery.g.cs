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
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.QueryDsl
{
	public interface ISpanQueryVariant
	{
		string SpanQueryVariantName { get; }
	}

	[JsonConverter(typeof(SpanQueryConverter))]
	public partial class SpanQuery : IContainer
	{
		public SpanQuery(ISpanQueryVariant variant) => Variant = variant ?? throw new ArgumentNullException(nameof(variant));
		internal ISpanQueryVariant Variant { get; }
	}

	internal sealed class SpanQueryConverter : JsonConverter<SpanQuery>
	{
		public override SpanQuery Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			reader.Read();
			if (reader.TokenType != JsonTokenType.PropertyName)
			{
				throw new JsonException();
			}

			var propertyName = reader.GetString();
			if (propertyName == "span_containing")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.SpanContainingQuery?>(ref reader, options);
				reader.Read();
				return new SpanQuery(variant);
			}

			if (propertyName == "field_masking_span")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.SpanFieldMaskingQuery?>(ref reader, options);
				reader.Read();
				return new SpanQuery(variant);
			}

			if (propertyName == "span_first")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.SpanFirstQuery?>(ref reader, options);
				reader.Read();
				return new SpanQuery(variant);
			}

			if (propertyName == "span_multi")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.SpanMultiTermQuery?>(ref reader, options);
				reader.Read();
				return new SpanQuery(variant);
			}

			if (propertyName == "span_near")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.SpanNearQuery?>(ref reader, options);
				reader.Read();
				return new SpanQuery(variant);
			}

			if (propertyName == "span_not")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.SpanNotQuery?>(ref reader, options);
				reader.Read();
				return new SpanQuery(variant);
			}

			if (propertyName == "span_or")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.SpanOrQuery?>(ref reader, options);
				reader.Read();
				return new SpanQuery(variant);
			}

			if (propertyName == "span_term")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.SpanTermQuery?>(ref reader, options);
				reader.Read();
				return new SpanQuery(variant);
			}

			if (propertyName == "span_within")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.SpanWithinQuery?>(ref reader, options);
				reader.Read();
				return new SpanQuery(variant);
			}

			throw new JsonException();
		}

		public override void Write(Utf8JsonWriter writer, SpanQuery value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WritePropertyName(value.Variant.SpanQueryVariantName);
			switch (value.Variant)
			{
				case Elastic.Clients.Elasticsearch.QueryDsl.SpanContainingQuery variant:
					JsonSerializer.Serialize(writer, variant, options);
					break;
				case Elastic.Clients.Elasticsearch.QueryDsl.SpanFieldMaskingQuery variant:
					JsonSerializer.Serialize(writer, variant, options);
					break;
				case Elastic.Clients.Elasticsearch.QueryDsl.SpanFirstQuery variant:
					JsonSerializer.Serialize(writer, variant, options);
					break;
				case Elastic.Clients.Elasticsearch.QueryDsl.SpanMultiTermQuery variant:
					JsonSerializer.Serialize(writer, variant, options);
					break;
				case Elastic.Clients.Elasticsearch.QueryDsl.SpanNearQuery variant:
					JsonSerializer.Serialize(writer, variant, options);
					break;
				case Elastic.Clients.Elasticsearch.QueryDsl.SpanNotQuery variant:
					JsonSerializer.Serialize(writer, variant, options);
					break;
				case Elastic.Clients.Elasticsearch.QueryDsl.SpanOrQuery variant:
					JsonSerializer.Serialize(writer, variant, options);
					break;
				case Elastic.Clients.Elasticsearch.QueryDsl.SpanTermQuery variant:
					JsonSerializer.Serialize(writer, variant, options);
					break;
				case Elastic.Clients.Elasticsearch.QueryDsl.SpanWithinQuery variant:
					JsonSerializer.Serialize(writer, variant, options);
					break;
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class SpanQueryDescriptor<T> : DescriptorBase<SpanQueryDescriptor<T>>
	{
		public SpanQueryDescriptor()
		{
		}

		internal SpanQueryDescriptor(Action<SpanQueryDescriptor<T>> configure) => configure.Invoke(this);
		internal bool ContainsVariant { get; private set; }

		internal string ContainedVariantName { get; private set; }

		internal SpanQuery Container { get; private set; }

		internal object ContainerVariantDescriptorAction { get; private set; }

		private void Set(object descriptorAction, string variantName)
		{
			if (ContainsVariant)
				throw new Exception("TODO");
			ContainerVariantDescriptorAction = descriptorAction;
			ContainedVariantName = variantName;
			ContainsVariant = true;
		}

		private void Set(ISpanQueryVariant variant, string variantName)
		{
			if (ContainsVariant)
				throw new Exception("TODO");
			Container = new SpanQuery(variant);
			ContainedVariantName = variantName;
			ContainsVariant = true;
		}

		public void SpanContaining(SpanContainingQuery variant) => Set(variant, "span_containing");
		public void SpanContaining(Action<SpanContainingQueryDescriptor<T>> configure) => Set(configure, "span_containing");
		public void FieldMaskingSpan(SpanFieldMaskingQuery variant) => Set(variant, "field_masking_span");
		public void FieldMaskingSpan(Action<SpanFieldMaskingQueryDescriptor<T>> configure) => Set(configure, "field_masking_span");
		public void SpanFirst(SpanFirstQuery variant) => Set(variant, "span_first");
		public void SpanFirst(Action<SpanFirstQueryDescriptor<T>> configure) => Set(configure, "span_first");
		public void SpanMulti(SpanMultiTermQuery variant) => Set(variant, "span_multi");
		public void SpanMulti(Action<SpanMultiTermQueryDescriptor<T>> configure) => Set(configure, "span_multi");
		public void SpanNear(SpanNearQuery variant) => Set(variant, "span_near");
		public void SpanNear(Action<SpanNearQueryDescriptor> configure) => Set(configure, "span_near");
		public void SpanNot(SpanNotQuery variant) => Set(variant, "span_not");
		public void SpanNot(Action<SpanNotQueryDescriptor<T>> configure) => Set(configure, "span_not");
		public void SpanOr(SpanOrQuery variant) => Set(variant, "span_or");
		public void SpanOr(Action<SpanOrQueryDescriptor> configure) => Set(configure, "span_or");
		public void SpanTerm(SpanTermQuery variant) => Set(variant, "span_term");
		public void SpanTerm(Action<SpanTermQueryDescriptor> configure) => Set(configure, "span_term");
		public void SpanWithin(SpanWithinQuery variant) => Set(variant, "span_within");
		public void SpanWithin(Action<SpanWithinQueryDescriptor<T>> configure) => Set(configure, "span_within");
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			if (!ContainsVariant)
			{
				writer.WriteNullValue();
				return;
			}

			if (Container is not null)
			{
				JsonSerializer.Serialize(writer, Container, options);
				return;
			}

			writer.WriteStartObject();
			writer.WritePropertyName(ContainedVariantName);
			writer.WriteStartObject();
			if (ContainedVariantName == "span_containing")
			{
				var descriptor = new SpanContainingQueryDescriptor<T>();
				((Action<SpanContainingQueryDescriptor<T>>)ContainerVariantDescriptorAction).Invoke(descriptor);
				JsonSerializer.Serialize(writer, descriptor, options);
				Finalise();
				return;
			}

			if (ContainedVariantName == "field_masking_span")
			{
				var descriptor = new SpanFieldMaskingQueryDescriptor<T>();
				((Action<SpanFieldMaskingQueryDescriptor<T>>)ContainerVariantDescriptorAction).Invoke(descriptor);
				JsonSerializer.Serialize(writer, descriptor, options);
				Finalise();
				return;
			}

			if (ContainedVariantName == "span_first")
			{
				var descriptor = new SpanFirstQueryDescriptor<T>();
				((Action<SpanFirstQueryDescriptor<T>>)ContainerVariantDescriptorAction).Invoke(descriptor);
				JsonSerializer.Serialize(writer, descriptor, options);
				Finalise();
				return;
			}

			if (ContainedVariantName == "span_multi")
			{
				var descriptor = new SpanMultiTermQueryDescriptor<T>();
				((Action<SpanMultiTermQueryDescriptor<T>>)ContainerVariantDescriptorAction).Invoke(descriptor);
				JsonSerializer.Serialize(writer, descriptor, options);
				Finalise();
				return;
			}

			if (ContainedVariantName == "span_near")
			{
				var descriptor = new SpanNearQueryDescriptor();
				((Action<SpanNearQueryDescriptor>)ContainerVariantDescriptorAction).Invoke(descriptor);
				JsonSerializer.Serialize(writer, descriptor, options);
				Finalise();
				return;
			}

			if (ContainedVariantName == "span_not")
			{
				var descriptor = new SpanNotQueryDescriptor<T>();
				((Action<SpanNotQueryDescriptor<T>>)ContainerVariantDescriptorAction).Invoke(descriptor);
				JsonSerializer.Serialize(writer, descriptor, options);
				Finalise();
				return;
			}

			if (ContainedVariantName == "span_or")
			{
				var descriptor = new SpanOrQueryDescriptor();
				((Action<SpanOrQueryDescriptor>)ContainerVariantDescriptorAction).Invoke(descriptor);
				JsonSerializer.Serialize(writer, descriptor, options);
				Finalise();
				return;
			}

			if (ContainedVariantName == "span_term")
			{
				var descriptor = new SpanTermQueryDescriptor();
				((Action<SpanTermQueryDescriptor>)ContainerVariantDescriptorAction).Invoke(descriptor);
				JsonSerializer.Serialize(writer, descriptor, options);
				Finalise();
				return;
			}

			if (ContainedVariantName == "span_within")
			{
				var descriptor = new SpanWithinQueryDescriptor<T>();
				((Action<SpanWithinQueryDescriptor<T>>)ContainerVariantDescriptorAction).Invoke(descriptor);
				JsonSerializer.Serialize(writer, descriptor, options);
				Finalise();
				return;
			}

			writer.WriteEndObject();
			writer.WriteEndObject();
			void Finalise()
			{
				writer.WriteEndObject();
				writer.WriteEndObject();
			}
		}
	}
}