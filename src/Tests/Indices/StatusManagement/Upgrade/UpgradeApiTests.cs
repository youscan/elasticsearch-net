using System;
using Elasticsearch252.Net;
using Nest252;
using Tests.Framework;
using Tests.Framework.Integration;
using Tests.Framework.MockData;
using Xunit;
using static Nest252.Infer;

namespace Tests.Indices.StatusManagement.Upgrade
{
	public class UpgradeApiTests
		: ApiIntegrationAgainstNewIndexTestBase
			<IntrusiveOperationCluster, IUpgradeResponse, IUpgradeRequest, UpgradeDescriptor, UpgradeRequest>
	{
		public UpgradeApiTests(IntrusiveOperationCluster cluster, EndpointUsage usage) : base(cluster, usage) { }

		protected override LazyResponses ClientUsage() => Calls(
			fluent: (client, f) => client.Upgrade(CallIsolatedValue, f),
			fluentAsync: (client, f) => client.UpgradeAsync(CallIsolatedValue, f),
			request: (client, r) => client.Upgrade(r),
			requestAsync: (client, r) => client.UpgradeAsync(r)
		);

		protected override bool ExpectIsValid => true;
		protected override int ExpectStatusCode => 200;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override string UrlPath => $"/{CallIsolatedValue}/_upgrade?allow_no_indices=true";

		protected override Func<UpgradeDescriptor, IUpgradeRequest> Fluent => d => d.AllowNoIndices();

		protected override UpgradeRequest Initializer => new UpgradeRequest(CallIsolatedValue) { AllowNoIndices = true };
	}
}
