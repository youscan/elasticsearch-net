using System.Threading.Tasks;
using Nest252;

namespace Profiling.Async
{
	public interface IAsyncProfiledOperation
	{
		Task RunAsync(IElasticClient client, ColoredConsoleWriter output);
	}
}