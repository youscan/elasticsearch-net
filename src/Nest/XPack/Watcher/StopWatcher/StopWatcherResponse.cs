using Newtonsoft.Json;

namespace Nest252
{
	[JsonObject]
	public interface IStopWatcherResponse : IAcknowledgedResponse {}

	public class StopWatcherResponse : AcknowledgedResponseBase, IStopWatcherResponse {}
}
