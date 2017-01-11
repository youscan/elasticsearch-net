using Newtonsoft.Json;

namespace Nest500
{
	[JsonObject]
	public interface IStartWatcherResponse : IAcknowledgedResponse {}

	public class StartWatcherResponse : AcknowledgedResponseBase, IStartWatcherResponse {}
}
