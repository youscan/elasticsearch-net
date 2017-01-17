using System;
using System.Threading.Tasks;
using Elasticsearch252.Net;

namespace Nest252
{
	public partial interface IElasticClient
	{
		/// <inheritdoc/>
		ICatResponse<CatShardsRecord> CatShards(Func<CatShardsDescriptor, ICatShardsRequest> selector = null);

		/// <inheritdoc/>
		ICatResponse<CatShardsRecord> CatShards(ICatShardsRequest request);

		/// <inheritdoc/>
		Task<ICatResponse<CatShardsRecord>> CatShardsAsync(Func<CatShardsDescriptor, ICatShardsRequest> selector = null);

		/// <inheritdoc/>
		Task<ICatResponse<CatShardsRecord>> CatShardsAsync(ICatShardsRequest request);
	}

	public partial class ElasticClient
	{
		/// <inheritdoc/>
		public ICatResponse<CatShardsRecord> CatShards(Func<CatShardsDescriptor, ICatShardsRequest> selector = null) =>
			this.CatShards(selector.InvokeOrDefault(new CatShardsDescriptor()));

		/// <inheritdoc/>
		public ICatResponse<CatShardsRecord> CatShards(ICatShardsRequest request) =>
			this.DoCat<ICatShardsRequest, CatShardsRequestParameters, CatShardsRecord>(request, this.LowLevelDispatch.CatShardsDispatch<CatResponse<CatShardsRecord>>);

		/// <inheritdoc/>
		public Task<ICatResponse<CatShardsRecord>> CatShardsAsync(Func<CatShardsDescriptor, ICatShardsRequest> selector = null) =>
			this.CatShardsAsync(selector.InvokeOrDefault(new CatShardsDescriptor()));

		public Task<ICatResponse<CatShardsRecord>> CatShardsAsync(ICatShardsRequest request) =>
			this.DoCatAsync<ICatShardsRequest, CatShardsRequestParameters, CatShardsRecord>(request, this.LowLevelDispatch.CatShardsDispatchAsync<CatResponse<CatShardsRecord>>);

	}
}