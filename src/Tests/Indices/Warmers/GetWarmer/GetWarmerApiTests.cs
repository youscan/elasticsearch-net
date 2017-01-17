using System;
using Elasticsearch252.Net;
using Nest252;
using Tests.Framework;
using Tests.Framework.Integration;
using Tests.Framework.MockData;
using Xunit;
using static Nest252.Infer;

namespace Tests.Indices.Warmers.GetWarmer
{
	public class GetWarmerApiTests : ApiTestBase<ReadOnlyCluster, IGetWarmerResponse, IGetWarmerRequest, GetWarmerDescriptor, GetWarmerRequest>
	{
		public GetWarmerApiTests(ReadOnlyCluster cluster, EndpointUsage usage) : base(cluster, usage) { }

		protected override LazyResponses ClientUsage() => Calls(
			fluent: (client, f) => client.GetWarmer(f),
			fluentAsync: (client, f) => client.GetWarmerAsync(f),
			request: (client, r) => client.GetWarmer(r),
			requestAsync: (client, r) => client.GetWarmerAsync(r)
		);

		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override string UrlPath => "/project/_warmer/warmer1%2Cwarmer2";

		protected override Func<GetWarmerDescriptor, IGetWarmerRequest> Fluent => d => d
			.Index<Project>()
			.Name("warmer1,warmer2");

		protected override GetWarmerRequest Initializer => new GetWarmerRequest(Index<Project>(), Names("warmer1", "warmer2"));
	}
}
