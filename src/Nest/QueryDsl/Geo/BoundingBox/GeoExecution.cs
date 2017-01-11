using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Nest500
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum GeoExecution
	{
		[EnumMember(Value = "memory")]
		Memory,
		[EnumMember(Value = "indexed")]
		Indexed
	}
}
