using Newtonsoft.Json;

namespace Nest252
{
	[JsonObject]
	public class AttachData
	{
		[JsonProperty("format")]
		public DataAttachmentFormat Format { get; set; }
	}
}
