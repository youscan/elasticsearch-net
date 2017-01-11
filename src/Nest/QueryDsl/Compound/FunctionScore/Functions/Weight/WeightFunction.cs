using Newtonsoft.Json;

namespace Nest500
{
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public interface IWeightFunction : IScoreFunction
	{
	}

	public class WeightFunction : FunctionScoreFunctionBase, IWeightFunction { }

	public class WeightFunctionDescriptor<T> : FunctionScoreFunctionDescriptorBase<WeightFunctionDescriptor<T>, IWeightFunction,T> , IWeightFunction
		where T : class
	{
	}
}
