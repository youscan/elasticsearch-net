﻿using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using Nest;
using Tests.Framework.EndpointTests;
using static Tests.Framework.EndpointTests.UrlTester;

namespace Tests.XPack.MachineLearning.GetCalendars
{
	public class GetCalendarsUrlTests : UrlTestsBase
	{
		[U] public override async Task Urls()
		{
			await POST("/_ml/calendars")
				.Fluent(c => c.MachineLearning.GetCalendars(p => p))
				.Request(c => c.MachineLearning.GetCalendars(new GetCalendarsRequest()))
				.FluentAsync(c => c.MachineLearning.GetCalendarsAsync(p => p))
				.RequestAsync(c => c.MachineLearning.GetCalendarsAsync(new GetCalendarsRequest()));

			await POST("/_ml/calendars/1")
				.Request(c => c.MachineLearning.GetCalendars(new GetCalendarsRequest(1)))
				.Fluent(c => c.MachineLearning.GetCalendars(r => r.CalendarId(1)))
				.FluentAsync(c => c.MachineLearning.GetCalendarsAsync(r => r.CalendarId(1)))
				.RequestAsync(c => c.MachineLearning.GetCalendarsAsync(new GetCalendarsRequest(1)));
		}
	}
}
