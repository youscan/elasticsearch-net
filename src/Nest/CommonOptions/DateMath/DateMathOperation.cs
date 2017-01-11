using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Nest500
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DateMathOperation
	{
		[EnumMember(Value = "+")]
		Add,
		[EnumMember(Value = "-")]
		Subtract
	}
}