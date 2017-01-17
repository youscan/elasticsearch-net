using Newtonsoft.Json;

namespace Nest252
{
	[JsonObject]
	public interface IInput {}

	public abstract class InputBase : IInput
	{
		internal abstract void WrapInContainer(IInputContainer container);
	}
}
