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
namespace Elastic.Clients.Elasticsearch.Ml
{
	public partial class DataframeAnalysisFeatureProcessorOneHotEncoding : IDataframeAnalysisFeatureProcessorVariant
	{
		[JsonInclude]
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("hot_map")]
		public string HotMap { get; set; }
	}

	public sealed partial class DataframeAnalysisFeatureProcessorOneHotEncodingDescriptor<TDocument> : SerializableDescriptorBase<DataframeAnalysisFeatureProcessorOneHotEncodingDescriptor<TDocument>>
	{
		internal DataframeAnalysisFeatureProcessorOneHotEncodingDescriptor(Action<DataframeAnalysisFeatureProcessorOneHotEncodingDescriptor<TDocument>> configure) => configure.Invoke(this);
		public DataframeAnalysisFeatureProcessorOneHotEncodingDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

		private string HotMapValue { get; set; }

		public DataframeAnalysisFeatureProcessorOneHotEncodingDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
		{
			FieldValue = field;
			return Self;
		}

		public DataframeAnalysisFeatureProcessorOneHotEncodingDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public DataframeAnalysisFeatureProcessorOneHotEncodingDescriptor<TDocument> HotMap(string hotMap)
		{
			HotMapValue = hotMap;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
			writer.WritePropertyName("hot_map");
			writer.WriteStringValue(HotMapValue);
			writer.WriteEndObject();
		}
	}

	public sealed partial class DataframeAnalysisFeatureProcessorOneHotEncodingDescriptor : SerializableDescriptorBase<DataframeAnalysisFeatureProcessorOneHotEncodingDescriptor>
	{
		internal DataframeAnalysisFeatureProcessorOneHotEncodingDescriptor(Action<DataframeAnalysisFeatureProcessorOneHotEncodingDescriptor> configure) => configure.Invoke(this);
		public DataframeAnalysisFeatureProcessorOneHotEncodingDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

		private string HotMapValue { get; set; }

		public DataframeAnalysisFeatureProcessorOneHotEncodingDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
		{
			FieldValue = field;
			return Self;
		}

		public DataframeAnalysisFeatureProcessorOneHotEncodingDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public DataframeAnalysisFeatureProcessorOneHotEncodingDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
		{
			FieldValue = field;
			return Self;
		}

		public DataframeAnalysisFeatureProcessorOneHotEncodingDescriptor HotMap(string hotMap)
		{
			HotMapValue = hotMap;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
			writer.WritePropertyName("hot_map");
			writer.WriteStringValue(HotMapValue);
			writer.WriteEndObject();
		}
	}
}