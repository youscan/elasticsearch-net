using System.IO;

namespace Elasticsearch500.Net
{
	public interface IMemoryStreamFactory
	{
		MemoryStream Create();
	}

	public class MemoryStreamFactory : IMemoryStreamFactory
	{
		public MemoryStream Create() => new MemoryStream();
	}
}