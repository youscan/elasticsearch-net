using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Nest252
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SortSpecialField
	{
		[EnumMember(Value = "_score")]
		Score,
		[EnumMember(Value = "_doc")]
		DocumentIndexOrder
	}
}