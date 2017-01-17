using Newtonsoft.Json;

namespace Nest252
{
	public class RecoveryIndexStatus
	{
		[JsonProperty("total_time_in_millis")]
		public long TotalTimeInMilliseconds { get; internal set; }

		[JsonProperty("bytes")]
		public RecoveryBytes Bytes { get; internal set; }

		[JsonProperty("files")]
		public RecoveryFiles Files { get; internal set; }

	}
}