using Newtonsoft.Json;

namespace Nest500
{
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class BinaryAttribute : ElasticsearchDocValuesPropertyAttributeBase, IBinaryProperty
	{
		public BinaryAttribute() : base("binary") { }
	}
}
