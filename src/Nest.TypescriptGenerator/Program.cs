using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TypeLite;
using TypeLite.Net4;
using Elasticsearch.Net;

namespace Nest.TypescriptGenerator
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var isDescriptorRe = new Regex(@"Descriptor(?:\<.+$|$)");

			var nestAssembly = typeof(IRequest<>).Assembly;
			var lowLevelAssembly = typeof(IElasticLowLevelClient).Assembly;
			var nestInterfaces = nestAssembly
				.GetTypes()
				.Where(t => typeof(IRequest).IsAssignableFrom(t) || typeof(IResponse).IsAssignableFrom(t))
				.Where(t => t.IsClass && !isDescriptorRe.IsMatch(t.Name))
				.ToArray();

			var requestParameters = lowLevelAssembly
				.GetTypes()
				.Where(t => t.IsClass && t.Name.EndsWith("RequestParameters"))
				.ToDictionary(t=>t.Name.Replace("Parameters", ""));

			var definitions = nestInterfaces.Aggregate(
				TypeScript.Definitions()
					.WithMemberFormatter(i =>
					{
						var declaringType = i.MemberInfo.DeclaringType;
						if (declaringType.Name.Contains("Request") && requestParameters.ContainsKey(declaringType.Name))
						{
							var rp = requestParameters[declaringType.Name];
							var method = rp.GetMethod(i.MemberInfo.Name);
							if (method != null)
							{

							}
						}

						JsonPropertyAttribute jsonPropertyAttribute;
						var iface = declaringType.GetInterfaces().FirstOrDefault(ii => ii.Name == "I" + declaringType.Name);
						if (iface != null)
						{
							var ifaceProperty = iface.GetProperty(i.MemberInfo.Name);
							jsonPropertyAttribute = ifaceProperty?.GetCustomAttributes(typeof(JsonPropertyAttribute), true).FirstOrDefault() as JsonPropertyAttribute;
							if (jsonPropertyAttribute != null)
								return jsonPropertyAttribute.PropertyName;
						}

						jsonPropertyAttribute = i.MemberInfo.GetCustomAttributes(typeof(JsonPropertyAttribute), true).FirstOrDefault() as JsonPropertyAttribute;
						if (jsonPropertyAttribute != null)
							return jsonPropertyAttribute.PropertyName;
						return i.MemberInfo.Name;
					})
				, (def, t) => def.For(t)
			);

			if (!Directory.Exists(@"c:\temp"))
			{
				Directory.CreateDirectory(@"c:\temp");
			}

			File.WriteAllText(@"c:\temp\interfaces.ts", definitions.Generate());
		}
	}
}
