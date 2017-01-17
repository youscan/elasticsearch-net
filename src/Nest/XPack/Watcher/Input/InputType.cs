using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Nest252
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum InputType
	{
		[EnumMember(Value = "http")]
		Http,
		[EnumMember(Value = "search")]
		Search,
		[EnumMember(Value = "simple")]
		Simple
	}
}
