using Newtonsoft.Json;

namespace Nest252
{
	public interface IPingResponse : IResponse
	{
	}

	[JsonObject]
	public class PingResponse : ResponseBase, IPingResponse
	{
	}
}
