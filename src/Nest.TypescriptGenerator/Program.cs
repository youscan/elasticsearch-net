using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
							   .WithTypeFormatter((type, f) =>
							   {
								   var iface = type.Type.GetInterfaces().FirstOrDefault(i => i.Name == "I" + type.Type.Name);
								   if (iface == null)
									   return type.Type.Name;
								   var jsonConverterAttribute = iface.GetCustomAttributes(typeof(JsonConverterAttribute), true).FirstOrDefault() as JsonConverterAttribute;
								   if (jsonConverterAttribute == null)
									   jsonConverterAttribute = type.Type.GetCustomAttributes(typeof(JsonConverterAttribute), true).FirstOrDefault() as JsonConverterAttribute;
								   if (jsonConverterAttribute != null)
									   return "/** herebedragons! */ " + type.Type.Name;
								   return type.Type.Name;
							   })
							   .WithMemberFormatter(i =>
							   {
								   var declaringType = i.MemberInfo.DeclaringType;
								   var iface = declaringType.GetInterfaces().FirstOrDefault(ii => ii.Name == "I" + declaringType.Name);
								   if (iface == null)
									   return i.MemberInfo.Name;
								   var ifaceProperty = iface.GetProperty(i.MemberInfo.Name);
								   if (ifaceProperty == null)
									   return i.MemberInfo.Name;
								   var jsonPropertyAttribute = GetAttribute<JsonPropertyAttribute>(ifaceProperty, i.MemberInfo);
								   var propertyName = (jsonPropertyAttribute != null) ? jsonPropertyAttribute.PropertyName : i.MemberInfo.Name;
								   var jsonConverterAttribute = GetAttribute<JsonConverterAttribute>(ifaceProperty, i.MemberInfo);
								   if (jsonConverterAttribute != null)
									   return "/** herebedragons! */ " + propertyName;
								   return propertyName;
							   })
			);

	        if (!Directory.Exists(@"c:\temp"))
	        {
		        Directory.CreateDirectory(@"c:\temp");
	        }

			File.WriteAllText(@"c:\temp\interfaces.ts", definitions.Generate());
        }

		private static TAttribute GetAttribute<TAttribute>(PropertyInfo propertyInfo, MemberInfo memberInfo)
			where TAttribute : Attribute
		{
			var attribute = propertyInfo.GetCustomAttributes(typeof(TAttribute), true).FirstOrDefault() as TAttribute;
			if (attribute == null)
				attribute = memberInfo.GetCustomAttributes(typeof(TAttribute), true).FirstOrDefault() as TAttribute;
			return attribute;
		}
    }
}
