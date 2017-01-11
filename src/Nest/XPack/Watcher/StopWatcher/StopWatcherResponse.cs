using Newtonsoft.Json;

namespace Nest500
{
	[JsonObject]
	public interface IStopWatcherResponse : IAcknowledgedResponse {}

	public class StopWatcherResponse : AcknowledgedResponseBase, IStopWatcherResponse {}
}
