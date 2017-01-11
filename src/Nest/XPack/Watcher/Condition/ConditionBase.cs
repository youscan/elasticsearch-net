using Newtonsoft.Json;

namespace Nest500
{
	[JsonObject]
	public interface ICondition {}

	public abstract class ConditionBase : ICondition
	{
		internal abstract void WrapInContainer(IConditionContainer container);
	}
}
