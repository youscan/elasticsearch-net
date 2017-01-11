using Newtonsoft.Json;

namespace Nest500
{
	[JsonObject]
	[JsonConverter(typeof(ReadAsTypeJsonConverter<HttpInputRequestResult>))]
	public class HttpInputRequestResult : HttpInputRequest {}
}
