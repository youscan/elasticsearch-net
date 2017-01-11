using Newtonsoft.Json;

namespace Nest500
{
	public interface IClearScrollResponse : IResponse { }

	[JsonObject]
	public class ClearScrollResponse : ResponseBase, IClearScrollResponse { }
}
