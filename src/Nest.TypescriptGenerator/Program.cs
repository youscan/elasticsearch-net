using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TypeLite;
using TypeLite.TsModels;

namespace Nest.TypescriptGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
	        var nestInterfaces = typeof (IRequest).Assembly
		        .GetTypes()
		        .Where(t => typeof(IRequest).IsAssignableFrom(t) || typeof(IResponse).IsAssignableFrom(t))
				.Where(t => t.IsClass && !t.Name.EndsWith("Descriptor"))
		        .ToArray();

	        var typeScriptFluent = TypeScript.Definitions()
		        .WithMemberFormatter(FormatMember)
		        .WithVisibility((@class, name) => false)
				.WithModuleNameFormatter(module => "Elasticsearch");

			var definitions = nestInterfaces.Aggregate(typeScriptFluent, (def, t) => def.For(t));

	        if (!Directory.Exists(@"c:\temp"))
	        {
		        Directory.CreateDirectory(@"c:\temp");
	        }

			File.WriteAllText(@"c:\temp\interfaces.ts", definitions.Generate());
        }

	    private static string FormatMember(TsProperty property)
	    {
			    var declaringType = property.MemberInfo.DeclaringType;
			    var iface = declaringType.GetInterfaces().FirstOrDefault(ii => ii.Name == "I" + declaringType.Name);
			    if (iface == null)
				    return property.MemberInfo.Name;
			    var ifaceProperty = iface.GetProperty(property.MemberInfo.Name);
			    if (ifaceProperty == null)
				    return property.MemberInfo.Name;
			    var jsonPropertyAttribute =
				    ifaceProperty.GetCustomAttributes(typeof (JsonPropertyAttribute), true).FirstOrDefault() as
					    JsonPropertyAttribute;
			    if (jsonPropertyAttribute != null)
				    return jsonPropertyAttribute.PropertyName;
			    jsonPropertyAttribute =
				    property.MemberInfo.GetCustomAttributes(typeof (JsonPropertyAttribute), true).FirstOrDefault() as
					    JsonPropertyAttribute;
			    if (jsonPropertyAttribute != null)
				    return jsonPropertyAttribute.PropertyName;
			    return property.MemberInfo.Name;
	    }
    }
}
