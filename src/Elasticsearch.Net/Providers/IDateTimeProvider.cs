using System;

namespace Elasticsearch252.Net
{
	public interface IDateTimeProvider
	{
		DateTime Now();
		DateTime DeadTime(int attempts, TimeSpan? timeoutFactor, TimeSpan? maxDeadTimeout);
	}
}