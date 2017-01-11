using Newtonsoft.Json;

namespace Nest500
{
	public class SampleDiversity
	{
		[JsonProperty("field")]
		public Field Field { get; set; }

		[JsonProperty("max_docs_per_value")]
		public int? MaxDocumentsPerValue { get; set; }
	}
}
