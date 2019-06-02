﻿using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using Nest;
using Tests.Framework.EndpointTests;
using static Tests.Framework.EndpointTests.UrlTester;

namespace Tests.Indices.IndexSettings.IndexTemplates.IndexTemplateExists
{
	public class IndexTemplateUrlTests
	{
		[U] public async Task Urls()
		{
			var name = "temp";
			await HEAD($"/_template/{name}")
					.Fluent(c => c.Indices.TemplateExists(name))
					.Request(c => c.Indices.TemplateExists(new IndexTemplateExistsRequest(name)))
					.FluentAsync(c => c.Indices.TemplateExistsAsync(name))
					.RequestAsync(c => c.Indices.TemplateExistsAsync(new IndexTemplateExistsRequest(name)))
				;
		}
	}
}
