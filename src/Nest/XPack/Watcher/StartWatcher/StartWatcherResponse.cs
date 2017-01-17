using Newtonsoft.Json;

namespace Nest252
{
	[JsonObject]
	public interface IStartWatcherResponse : IAcknowledgedResponse {}

	public class StartWatcherResponse : AcknowledgedResponseBase, IStartWatcherResponse {}
}
