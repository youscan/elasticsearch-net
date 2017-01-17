using System;
using Elasticsearch252.Net;

namespace Nest252
{
	public partial interface IElasticClient 
	{
		IConnectionSettingsValues ConnectionSettings { get; }
		IElasticsearchSerializer Serializer { get; }
		IElasticLowLevelClient LowLevel { get; }
		Inferrer Infer { get; }
	}
}
