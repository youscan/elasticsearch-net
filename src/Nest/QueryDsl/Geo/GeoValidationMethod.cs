using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Nest500
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum GeoValidationMethod
	{
		[EnumMember(Value = "coerce")]
		Coerce,
		[EnumMember(Value = "ignore_malformed")]
		IgnoreMalformed,
		[EnumMember(Value = "strict")]
		Strict
	}
}