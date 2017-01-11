using Newtonsoft.Json;

namespace Nest500
{
	[JsonObject]
	[JsonConverter(typeof(BulkResponseItemJsonConverter))]
	public class BulkCreateResponseItem : BulkResponseItemBase
	{
		public override string Operation { get; internal set; }
	}
}