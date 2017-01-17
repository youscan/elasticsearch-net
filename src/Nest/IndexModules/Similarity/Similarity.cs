using Newtonsoft.Json;

namespace Nest252
{
	[ContractJsonConverter(typeof(SimilarityJsonConverter))]
	public interface ISimilarity
	{
		[JsonProperty("type")]
		string Type { get; }
	}
}
