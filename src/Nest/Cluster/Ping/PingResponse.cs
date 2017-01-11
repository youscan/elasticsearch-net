using Newtonsoft.Json;

namespace Nest500
{
	public interface IPingResponse : IResponse
	{
	}

	[JsonObject]
	public class PingResponse : ResponseBase, IPingResponse
	{
	}
}
