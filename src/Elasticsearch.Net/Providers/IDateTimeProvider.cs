using System;

namespace Elasticsearch500.Net
{
	public interface IDateTimeProvider
	{
		DateTime Now();
		DateTime DeadTime(int attempts, TimeSpan? timeoutFactor, TimeSpan? maxDeadTimeout);
	}
}