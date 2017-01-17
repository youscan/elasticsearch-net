using Newtonsoft.Json;

namespace Nest252
{
	public interface IClearScrollResponse : IResponse
	{
	}

	[JsonObject]
	public class ClearScrollResponse : ResponseBase, IClearScrollResponse
	{
	}
}