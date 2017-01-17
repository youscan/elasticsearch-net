using Newtonsoft.Json;

namespace Nest252
{
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	[JsonConverter(typeof (RangeQueryJsonConverter))]
	public interface IRangeQuery : IFieldNameQuery { }

}
