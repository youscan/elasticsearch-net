using System;
using Elasticsearch500.Net;

namespace Nest500
{
	public partial interface IElasticClient 
	{
		IConnectionSettingsValues ConnectionSettings { get; }
		IElasticsearchSerializer Serializer { get; }
		IElasticLowLevelClient LowLevel { get; }
		Inferrer Infer { get; }
	}
}
