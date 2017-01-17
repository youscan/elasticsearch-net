using Newtonsoft.Json;

namespace Nest252
{
	[JsonObject]
	public interface IRestartWatcherResponse : IAcknowledgedResponse {}

	public class RestartWatcherResponse : AcknowledgedResponseBase, IRestartWatcherResponse {}
}
