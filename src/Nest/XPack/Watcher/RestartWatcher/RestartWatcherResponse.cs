using Newtonsoft.Json;

namespace Nest500
{
	[JsonObject]
	public interface IRestartWatcherResponse : IAcknowledgedResponse {}

	public class RestartWatcherResponse : AcknowledgedResponseBase, IRestartWatcherResponse {}
}
