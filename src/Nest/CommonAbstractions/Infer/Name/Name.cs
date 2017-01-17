using Elasticsearch252.Net;

namespace Nest252
{
	public class Name : IUrlParameter
	{
		private readonly string _name;
		public Name(string name) { this._name = name; }

		public string GetString(IConnectionConfigurationValues settings) => _name;

		public static implicit operator Name(string name) => new Name(name);
	}
}
