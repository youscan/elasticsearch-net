using System.Runtime.Serialization;

// ReSharper disable InconsistentNaming

namespace Elasticsearch252.Net
{
	public enum HttpMethod
	{
		[EnumMember(Value = "GET")]
		GET,
		[EnumMember(Value = "POST")]
		POST,
		[EnumMember(Value = "PUT")]
		PUT,
		[EnumMember(Value = "DELETE")]
		DELETE,
		[EnumMember(Value = "HEAD")]
		HEAD
	}
}
