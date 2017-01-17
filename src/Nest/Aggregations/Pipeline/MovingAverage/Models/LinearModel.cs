using Newtonsoft.Json;

namespace Nest252
{
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public interface ILinearModel : IMovingAverageModel { }
	
	public class LinearModel : ILinearModel
	{
		string IMovingAverageModel.Name  { get; } = "linear";
	}

	public class LinearModelDescriptor
		: DescriptorBase<LinearModelDescriptor, ILinearModel>, ILinearModel
	{
		string IMovingAverageModel.Name { get; } = "linear";
	}
}
