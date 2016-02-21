using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TypeLite;
using TypeLite.Net4;

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

			var definitions = nestInterfaces.Aggregate(TypeScript.Definitions(),
				(def, t) => def.For(t)
							   .WithMemberFormatter(i =>
							   {
								   var declaringType = i.MemberInfo.DeclaringType;
								   var iface = declaringType.GetInterfaces().FirstOrDefault(ii => ii.Name == "I" + declaringType.Name);
								   if (iface == null)
									   return i.MemberInfo.Name;
								   var ifaceProperty = iface.GetProperty(i.MemberInfo.Name);
								   if (ifaceProperty == null)
									   return i.MemberInfo.Name;
								   var jsonPropertyAttribute = ifaceProperty.GetCustomAttributes(typeof(JsonPropertyAttribute), true).FirstOrDefault() as JsonPropertyAttribute;
								   if (jsonPropertyAttribute != null)
									   return jsonPropertyAttribute.PropertyName;
								   jsonPropertyAttribute = i.MemberInfo.GetCustomAttributes(typeof(JsonPropertyAttribute), true).FirstOrDefault() as JsonPropertyAttribute;
								   if (jsonPropertyAttribute != null)
									   return jsonPropertyAttribute.PropertyName;
								   return i.MemberInfo.Name;
							   })
			);

	        if (!Directory.Exists(@"c:\temp"))
	        {
		        Directory.CreateDirectory(@"c:\temp");
	        }

			File.WriteAllText(@"c:\temp\interfaces.ts", definitions.Generate());
        }
    }
}
