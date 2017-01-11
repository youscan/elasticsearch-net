using Newtonsoft.Json;

namespace Nest500
{
	[JsonObject(MemberSerialization.OptIn)]
	public interface IBinaryProperty : IDocValuesProperty
	{
	}

	public class BinaryProperty : DocValuesPropertyBase, IBinaryProperty
	{
		public BinaryProperty() : base("binary") { }
	}

	public class BinaryPropertyDescriptor<T>
		: DocValuesPropertyDescriptorBase<BinaryPropertyDescriptor<T>, IBinaryProperty, T>, IBinaryProperty
		where T : class
	{
		public BinaryPropertyDescriptor() : base("binary") { }
	}
}
