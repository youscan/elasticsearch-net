using Newtonsoft.Json;

namespace Nest500
{
	public class ExtendedBounds<T>
	{
		[JsonProperty("min")]
		public T Minimum { get; set; }

		[JsonProperty("max")]
		public T Maximum { get; set; }
	}
}