using Newtonsoft.Json;

namespace Nest252
{
	[JsonObject]
	[JsonConverter(typeof(BulkResponseItemJsonConverter))]
	public class BulkCreateResponseItem : BulkResponseItemBase
	{
		public override string Operation { get; internal set; }
	}
}