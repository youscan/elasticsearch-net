using System;
using Elasticsearch.Net;
using Newtonsoft.Json;

namespace Nest
{
	public class Ids : IUrlParameter
	{
		public string GetString(IConnectionConfigurationValues settings)
		{
			throw new NotImplementedException();
		}
	}
}
