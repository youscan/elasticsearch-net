using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Nest500
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SynonymFormat
	{
		[EnumMember(Value = "solr")]
		Solr,
		[EnumMember(Value = "wordnet")]
		WordNet
	}
}