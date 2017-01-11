using Newtonsoft.Json;

namespace Nest500
{
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	[JsonConverter(typeof (RangeQueryJsonConverter))]
	public interface IRangeQuery : IFieldNameQuery { }

}
