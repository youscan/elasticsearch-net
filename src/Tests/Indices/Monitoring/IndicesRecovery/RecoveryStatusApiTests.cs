﻿using System;
using Elasticsearch252.Net;
using Nest252;
using Tests.Framework;
using Tests.Framework.Integration;
using Xunit;

namespace Tests.Indices.Monitoring.IndicesRecovery
{
	public class RecoveryStatusApiTests : ApiIntegrationTestBase<ReadOnlyCluster, IRecoveryStatusResponse, IRecoveryStatusRequest, RecoveryStatusDescriptor, RecoveryStatusRequest>
	{
		public RecoveryStatusApiTests(ReadOnlyCluster cluster, EndpointUsage usage) : base(cluster, usage) { }

		protected override LazyResponses ClientUsage() => Calls(
			fluent: (client, f) => client.RecoveryStatus(Infer.AllIndices, f),
			fluentAsync: (client, f) => client.RecoveryStatusAsync(Infer.AllIndices, f),
			request: (client, r) => client.RecoveryStatus(r),
			requestAsync: (client, r) => client.RecoveryStatusAsync(r)
		);

		protected override bool ExpectIsValid => true;
		protected override int ExpectStatusCode => 200;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override string UrlPath => "/_recovery";

		protected override Func<RecoveryStatusDescriptor, IRecoveryStatusRequest> Fluent => d => d;

		protected override RecoveryStatusRequest Initializer => new RecoveryStatusRequest(Infer.AllIndices);
	}
}
