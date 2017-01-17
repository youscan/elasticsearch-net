using Nest252;

namespace Profiling
{
    public interface IProfiledOperation
    {
        void Run(IElasticClient client, ColoredConsoleWriter output);
    }
}