using Newtonsoft.Json;

namespace Nest252
{
	[ContractJsonConverter(typeof(ClusterRerouteCommandJsonConverter))]
	public interface IClusterRerouteCommand
	{
		[JsonIgnore]
		string Name { get; }
	}
}