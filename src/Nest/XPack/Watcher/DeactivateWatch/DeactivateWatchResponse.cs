using Newtonsoft.Json;

namespace Nest500
{
	public interface IDeactivateWatchResponse : IResponse
	{
		ActivationStatus Status { get; }
	}

	public class DeactivateWatchResponse : ResponseBase, IDeactivateWatchResponse
	{
		[JsonProperty("_status")]
		public ActivationStatus Status { get; internal set; }
	}
}
