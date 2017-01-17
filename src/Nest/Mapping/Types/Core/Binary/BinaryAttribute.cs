using Newtonsoft.Json;

namespace Nest252
{
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class BinaryAttribute : ElasticsearchPropertyAttributeBase, IBinaryProperty
	{
		public BinaryAttribute() : base("binary") { }
	}	
}
