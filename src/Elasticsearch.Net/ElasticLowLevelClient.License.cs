// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗  
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝  
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//  
// This file is automatically generated 
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net;
using static Elasticsearch.Net.HttpMethod;

// ReSharper disable InterpolatedStringExpressionIsNotIFormattable
// ReSharper disable once CheckNamespace
// ReSharper disable InterpolatedStringExpressionIsNotIFormattable
// ReSharper disable RedundantExtendsListEntry
namespace Elasticsearch.Net.Specification.LicenseApi
{
	///<summary>
	/// Logically groups all License API's together so that they may be discovered more naturally.
	/// <para>Not intended to be instantiated directly please defer to the <see cref = "IElasticLowLevelClient.License"/> property
	/// on <see cref = "IElasticLowLevelClient"/>.
	///</para>
	///</summary>
	public class LowLevelLicenseNamespace : NamespacedClientProxy
	{
		internal LowLevelLicenseNamespace(ElasticLowLevelClient client): base(client)
		{
		}

		///<summary>DELETE on /_license <para>https://www.elastic.co/guide/en/x-pack/current/license-management.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Delete<TResponse>(DeleteLicenseRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(DELETE, "_license", null, RequestParams(requestParameters));
		///<summary>DELETE on /_license <para>https://www.elastic.co/guide/en/x-pack/current/license-management.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public Task<TResponse> DeleteAsync<TResponse>(DeleteLicenseRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(DELETE, "_license", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_license <para>https://www.elastic.co/guide/en/x-pack/current/license-management.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Get<TResponse>(GetLicenseRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(GET, "_license", null, RequestParams(requestParameters));
		///<summary>GET on /_license <para>https://www.elastic.co/guide/en/x-pack/current/license-management.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public Task<TResponse> GetAsync<TResponse>(GetLicenseRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(GET, "_license", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_license/basic_status <para>https://www.elastic.co/guide/en/x-pack/current/license-management.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse GetBasicStatus<TResponse>(GetBasicLicenseStatusRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(GET, "_license/basic_status", null, RequestParams(requestParameters));
		///<summary>GET on /_license/basic_status <para>https://www.elastic.co/guide/en/x-pack/current/license-management.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public Task<TResponse> GetBasicStatusAsync<TResponse>(GetBasicLicenseStatusRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(GET, "_license/basic_status", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_license/trial_status <para>https://www.elastic.co/guide/en/x-pack/current/license-management.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse GetTrialStatus<TResponse>(GetTrialLicenseStatusRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(GET, "_license/trial_status", null, RequestParams(requestParameters));
		///<summary>GET on /_license/trial_status <para>https://www.elastic.co/guide/en/x-pack/current/license-management.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public Task<TResponse> GetTrialStatusAsync<TResponse>(GetTrialLicenseStatusRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(GET, "_license/trial_status", ctx, null, RequestParams(requestParameters));
		///<summary>PUT on /_license <para>https://www.elastic.co/guide/en/x-pack/current/license-management.html</para></summary>
		///<param name = "body">licenses to be installed</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Post<TResponse>(PostData body, PostLicenseRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(PUT, "_license", body, RequestParams(requestParameters));
		///<summary>PUT on /_license <para>https://www.elastic.co/guide/en/x-pack/current/license-management.html</para></summary>
		///<param name = "body">licenses to be installed</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public Task<TResponse> PostAsync<TResponse>(PostData body, PostLicenseRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(PUT, "_license", ctx, body, RequestParams(requestParameters));
		///<summary>POST on /_license/start_basic <para>https://www.elastic.co/guide/en/x-pack/current/license-management.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse StartBasic<TResponse>(StartBasicLicenseRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(POST, "_license/start_basic", null, RequestParams(requestParameters));
		///<summary>POST on /_license/start_basic <para>https://www.elastic.co/guide/en/x-pack/current/license-management.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public Task<TResponse> StartBasicAsync<TResponse>(StartBasicLicenseRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(POST, "_license/start_basic", ctx, null, RequestParams(requestParameters));
		///<summary>POST on /_license/start_trial <para>https://www.elastic.co/guide/en/x-pack/current/license-management.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse StartTrial<TResponse>(StartTrialLicenseRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(POST, "_license/start_trial", null, RequestParams(requestParameters));
		///<summary>POST on /_license/start_trial <para>https://www.elastic.co/guide/en/x-pack/current/license-management.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public Task<TResponse> StartTrialAsync<TResponse>(StartTrialLicenseRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(POST, "_license/start_trial", ctx, null, RequestParams(requestParameters));
	}
}