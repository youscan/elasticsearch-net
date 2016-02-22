using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using TypeLite;
using TypeLite.TsModels;
using Elasticsearch.Net;

namespace Nest.TypescriptGenerator
{
	public class Program
	{
		public static Dictionary<string, Type> RequestParameters { get; set; }
		private static ExposedTsGenerator _scriptGenerator;

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

			RequestParameters = lowLevelAssembly
				.GetTypes()
				.Where(t => t.IsClass && t.Name.EndsWith("RequestParameters"))
				.ToDictionary(t=>t.Name.Replace("Parameters", ""));

			_scriptGenerator = new ExposedTsGenerator();

			var typeScriptFluent = TypeScript.Definitions(_scriptGenerator)
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
			var propertyName = property.MemberInfo.Name;

			if (declaringType.Name.Contains("Request") && RequestParameters.ContainsKey(declaringType.Name))
			{
				var rp = RequestParameters[declaringType.Name];
				var method = rp.GetMethod(propertyName);
				if (method != null)
					return $"/** mapped on body but might only proxy to request querystring */ {propertyName}";
			}
			var iface = declaringType.GetInterfaces().FirstOrDefault(ii => ii.Name == "I" + declaringType.Name);
			var ifaceProperty = iface?.GetProperty(propertyName);

			var jsonPropertyAttribute = ifaceProperty?.GetCustomAttribute<JsonPropertyAttribute>() ??
			                            property.MemberInfo.GetCustomAttribute<JsonPropertyAttribute>();

			if (!string.IsNullOrWhiteSpace(jsonPropertyAttribute?.PropertyName))
				propertyName = jsonPropertyAttribute.PropertyName;

			var jsonConverterAttribute = ifaceProperty?.GetCustomAttribute<JsonConverterAttribute>() ??
										 property.MemberInfo.GetCustomAttribute<JsonConverterAttribute>();

			if (jsonConverterAttribute != null)
				propertyName = HereBeDragons(propertyName);

			return propertyName;
		}

		private static string FormatType(TsType type, ITsTypeFormatter formatter)
		{
			var iface = type.Type.GetInterfaces().FirstOrDefault(i => i.Name == "I" + type.Type.Name);
			var name = GenerateTypeName(type);

			if (iface == null) return name;

			var jsonConverterAttribute = iface.GetCustomAttribute<JsonConverterAttribute>() ??
			                             type.Type.GetCustomAttribute<JsonConverterAttribute>();

			return jsonConverterAttribute != null ? HereBeDragons(name) : name;
		}

		private static string HereBeDragons(string original) => 
			$"/** type has a custom json converter defined */ {original}";

		private static string GenerateTypeName(TsType type)
		{
			var tsClass = ((TsClass)type);
			if (!tsClass.GenericArguments.Any()) return tsClass.Name;
			return tsClass.Name + "<" + string.Join(", ", tsClass.GenericArguments.Select(a => a as TsCollection != null ? _scriptGenerator.GetFullyQualifiedTypeName(a) + "[]" : _scriptGenerator.GetFullyQualifiedTypeName(a))) + ">";
		}
	}
}
