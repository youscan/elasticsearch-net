using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Threading.Tasks;
using TypeLite;
using TypeLite.TsModels;
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
			var typeScriptFluent = TypeScript.Definitions()
				.WithTypeFormatter(FormatType)
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
if (declaringType.Name.Contains("Request") && requestParameters.ContainsKey(declaringType.Name))
						{
							var rp = requestParameters[declaringType.Name];
							var method = rp.GetMethod(i.MemberInfo.Name);
							if (method != null)
							{
			var iface = declaringType.GetInterfaces().FirstOrDefault(ii => ii.Name == "I" + declaringType.Name);
			if (iface == null)
				return property.MemberInfo.Name;
			var ifaceProperty = iface.GetProperty(property.MemberInfo.Name);
			if (ifaceProperty == null)
				return property.MemberInfo.Name;
			var jsonPropertyAttribute = GetAttribute<JsonPropertyAttribute>(ifaceProperty, property.MemberInfo);
			var propertyName = property.MemberInfo.Name;
			if (jsonPropertyAttribute != null)
				propertyName = jsonPropertyAttribute.PropertyName;
			var jsonConverterAttribute = GetAttribute<JsonConverterAttribute>(ifaceProperty, property.MemberInfo);
			if (jsonConverterAttribute != null)
				propertyName = HereBeDragons(propertyName);
			return propertyName;
		}

		private static string FormatType(TsType type, ITsTypeFormatter formatter)
		{
			var iface = type.Type.GetInterfaces().FirstOrDefault(i => i.Name == "I" + type.Type.Name);
			if (iface == null)
				return type.Type.Name;
			var jsonConverterAttribute = iface.GetCustomAttributes(typeof(JsonConverterAttribute), true).FirstOrDefault() as JsonConverterAttribute;
			if (jsonConverterAttribute == null)
				jsonConverterAttribute = type.Type.GetCustomAttributes(typeof(JsonConverterAttribute), true).FirstOrDefault() as JsonConverterAttribute;
			if (jsonConverterAttribute != null)
				return HereBeDragons(type.Type.Name);
			return type.Type.Name;
		}

		private static TAttribute GetAttribute<TAttribute>(PropertyInfo propertyInfo, MemberInfo memberInfo)
			where TAttribute : Attribute
		{
			var attribute = propertyInfo.GetCustomAttributes(typeof(TAttribute), true).FirstOrDefault() as TAttribute;
			if (attribute == null)
				attribute = memberInfo.GetCustomAttributes(typeof(TAttribute), true).FirstOrDefault() as TAttribute;
			return attribute;
		}

		private static string HereBeDragons(string original) => $"/** herebedragons! */ {original}";
	}
}
