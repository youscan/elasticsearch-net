using Newtonsoft.Json;

namespace Nest500
{
	[ContractJsonConverter(typeof(SimilarityJsonConverter))]
	public interface ISimilarity
	{
		[JsonProperty("type")]
		string Type { get; }
	}
}
