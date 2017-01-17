using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nest252
{
	[JsonConverter(typeof(TermsIncludeExcludeJsonConverter))]
	public class TermsIncludeExclude
	{
		[JsonProperty("pattern")]
		public string Pattern { get; set; }
		
		[JsonProperty("flags")]
		public string Flags { get; set; }
		
		[JsonIgnore]
		public IEnumerable<string> Values { get; set; }
	}
}