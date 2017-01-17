using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Nest252
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SamplerAggregationExecutionHint
	{
		[EnumMember(Value = "map")]
		Map,
        [EnumMember(Value = "global_ordinals")]
		GlobalOrdinals,
        [EnumMember(Value = "bytes_hash")]
		BytesHash
	}
}
