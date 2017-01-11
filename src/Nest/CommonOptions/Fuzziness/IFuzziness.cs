using Newtonsoft.Json;

namespace Nest500
{
	[JsonConverter(typeof(FuzzinessJsonConverter))]
	public interface IFuzziness
	{
		bool Auto { get;  }
		int? EditDistance { get;  }
		double? Ratio { get;  }
	}
}