using System;

namespace Elasticsearch252.Net
{
	internal static class Fluent
	{
		internal static TDescriptor Assign<TDescriptor, TInterface>(TDescriptor self, Action<TInterface> assign)
			where TDescriptor : class, TInterface
		{
			assign(self);
			return self;
		}
	}

}