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
namespace Elastic.Clients.Elasticsearch.Aggregations
{
	internal sealed class GeoDistanceAggregationConverter : JsonConverter<GeoDistanceAggregation>
	{
		public override GeoDistanceAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			return new GeoDistanceAggregation("");
		}

		public override void Write(Utf8JsonWriter writer, GeoDistanceAggregation value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("geo_distance");
			writer.WriteStartObject();
			writer.WriteEndObject();
			if (value.Meta is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, value.Meta, options);
			}

			if (value.Aggregations is not null)
			{
				writer.WritePropertyName("aggregations");
				JsonSerializer.Serialize(writer, value.Aggregations, options);
			}

			if (value.DistanceType is not null)
			{
				writer.WritePropertyName("distance_type");
				JsonSerializer.Serialize(writer, value.DistanceType, options);
			}

			if (value.Field is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, value.Field, options);
			}

			if (value.Origin is not null)
			{
				writer.WritePropertyName("origin");
				JsonSerializer.Serialize(writer, value.Origin, options);
			}

			if (value.Ranges is not null)
			{
				writer.WritePropertyName("ranges");
				JsonSerializer.Serialize(writer, value.Ranges, options);
			}

			if (value.Unit is not null)
			{
				writer.WritePropertyName("unit");
				JsonSerializer.Serialize(writer, value.Unit, options);
			}

			writer.WriteEndObject();
		}
	}

	[JsonConverter(typeof(GeoDistanceAggregationConverter))]
	public partial class GeoDistanceAggregation : Aggregations.BucketAggregationBase, IAggregationContainerVariant
	{
		[JsonConstructor]
		public GeoDistanceAggregation(string name) : base(name)
		{
		}

		[JsonIgnore]
		string Aggregations.IAggregationContainerVariant.AggregationContainerVariantName => "geo_distance";
		[JsonInclude]
		[JsonPropertyName("distance_type")]
		public Elastic.Clients.Elasticsearch.GeoDistanceType? DistanceType { get; set; }

		[JsonInclude]
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field? Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("origin")]
		public Elastic.Clients.Elasticsearch.GeoLocation? Origin { get; set; }

		[JsonInclude]
		[JsonPropertyName("ranges")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Aggregations.AggregationRange>? Ranges { get; set; }

		[JsonInclude]
		[JsonPropertyName("unit")]
		public Elastic.Clients.Elasticsearch.DistanceUnit? Unit { get; set; }
	}

	public sealed partial class GeoDistanceAggregationDescriptor<T> : DescriptorBase<GeoDistanceAggregationDescriptor<T>>
	{
		public GeoDistanceAggregationDescriptor()
		{
		}

		internal GeoDistanceAggregationDescriptor(Action<GeoDistanceAggregationDescriptor<T>> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.GeoDistanceType? DistanceTypeValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Field? FieldValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.GeoLocation? OriginValue { get; private set; }

		internal IEnumerable<Elastic.Clients.Elasticsearch.Aggregations.AggregationRange>? RangesValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.DistanceUnit? UnitValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? AggregationsValue { get; private set; }

		internal Dictionary<string, object>? MetaValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor<T> AggregationsDescriptor { get; private set; }

		internal Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor<T>> AggregationsDescriptorAction { get; private set; }

		public GeoDistanceAggregationDescriptor<T> DistanceType(Elastic.Clients.Elasticsearch.GeoDistanceType? distanceType) => Assign(distanceType, (a, v) => a.DistanceTypeValue = v);
		public GeoDistanceAggregationDescriptor<T> Field(Elastic.Clients.Elasticsearch.Field? field) => Assign(field, (a, v) => a.FieldValue = v);
		public GeoDistanceAggregationDescriptor<T> Field<TValue>(Expression<Func<T, TValue>> field) => Assign(field, (a, v) => a.FieldValue = v);
		public GeoDistanceAggregationDescriptor<T> Origin(Elastic.Clients.Elasticsearch.GeoLocation? origin) => Assign(origin, (a, v) => a.OriginValue = v);
		public GeoDistanceAggregationDescriptor<T> Ranges(IEnumerable<Elastic.Clients.Elasticsearch.Aggregations.AggregationRange>? ranges) => Assign(ranges, (a, v) => a.RangesValue = v);
		public GeoDistanceAggregationDescriptor<T> Unit(Elastic.Clients.Elasticsearch.DistanceUnit? unit) => Assign(unit, (a, v) => a.UnitValue = v);
		public GeoDistanceAggregationDescriptor<T> Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? aggregations)
		{
			AggregationsDescriptor = null;
			AggregationsDescriptorAction = null;
			return Assign(aggregations, (a, v) => a.AggregationsValue = v);
		}

		public GeoDistanceAggregationDescriptor<T> Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor<T> descriptor)
		{
			AggregationsValue = null;
			AggregationsDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.AggregationsDescriptor = v);
		}

		public GeoDistanceAggregationDescriptor<T> Aggregations(Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor<T>> configure)
		{
			AggregationsValue = null;
			AggregationsDescriptorAction = null;
			return Assign(configure, (a, v) => a.AggregationsDescriptorAction = v);
		}

		public GeoDistanceAggregationDescriptor<T> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector) => Assign(selector, (a, v) => a.MetaValue = v?.Invoke(new FluentDictionary<string, object>()));
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("geo_distance");
			writer.WriteStartObject();
			if (DistanceTypeValue is not null)
			{
				writer.WritePropertyName("distance_type");
				JsonSerializer.Serialize(writer, DistanceTypeValue, options);
			}

			if (FieldValue is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, FieldValue, options);
			}

			if (OriginValue is not null)
			{
				writer.WritePropertyName("origin");
				JsonSerializer.Serialize(writer, OriginValue, options);
			}

			if (RangesValue is not null)
			{
				writer.WritePropertyName("ranges");
				JsonSerializer.Serialize(writer, RangesValue, options);
			}

			if (UnitValue is not null)
			{
				writer.WritePropertyName("unit");
				JsonSerializer.Serialize(writer, UnitValue, options);
			}

			writer.WriteEndObject();
			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			if (AggregationsDescriptor is not null)
			{
				writer.WritePropertyName("aggregations");
				JsonSerializer.Serialize(writer, AggregationsDescriptor, options);
			}
			else if (AggregationsDescriptorAction is not null)
			{
				writer.WritePropertyName("aggregations");
				JsonSerializer.Serialize(writer, new AggregationContainerDescriptor<T>(AggregationsDescriptorAction), options);
			}
			else if (AggregationsValue is not null)
			{
				writer.WritePropertyName("aggregations");
				JsonSerializer.Serialize(writer, AggregationsValue, options);
			}

			writer.WriteEndObject();
		}
	}
}