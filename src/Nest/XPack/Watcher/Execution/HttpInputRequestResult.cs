using Newtonsoft.Json;

namespace Nest252
{
	[JsonObject]
	[JsonConverter(typeof(ReadAsTypeJsonConverter<HttpInputRequestResult>))]
	public class HttpInputRequestResult : HttpInputRequest {}
}
