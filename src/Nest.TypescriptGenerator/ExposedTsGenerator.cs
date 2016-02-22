using System.Collections.Generic;
using Elasticsearch.Net;
using System;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using TypeLite;
using TypeLite.TsModels;

namespace Nest.TypescriptGenerator
{
	public class ExposedTsGenerator : TsGenerator
	{
		public TypeConvertorCollection Converters => base._typeConvertors;

		public Dictionary<string,string> TypeRenames => new Dictionary<string, string>
		{
			{ "KeyValuePair", "Map" }
		}; 

		protected override void AppendEnumDefinition(TsEnum enumModel, ScriptBuilder sb, TsGeneratorOutput output)
		{
			string typeName = this.GetTypeName(enumModel);
			string visibility = string.Empty;

			_docAppender.AppendEnumDoc(sb, enumModel, typeName);

			string constSpecifier = this.GenerateConstEnums ? "const " : string.Empty;
			sb.AppendLineIndented(string.Format("{0}{2}enum {1} {{", visibility, typeName, constSpecifier));

			using (sb.IncreaseIndentation())
			{
				int i = 1;
				foreach (var v in enumModel.Values)
				{
					_docAppender.AppendEnumValueDoc(sb, v);
					var enumMemberAttribute = v.Field.GetCustomAttribute<EnumMemberAttribute>();
					var name = !string.IsNullOrEmpty(enumMemberAttribute?.Value) ? enumMemberAttribute.Value : v.Name;

					sb.AppendLineIndented(string.Format(i < enumModel.Values.Count ? "{0} = {1}," : "{0} = {1}", name, v.Value));
					i++;
				}
			}

			sb.AppendLineIndented("}");

			_generatedEnums.Add(enumModel);
		}

		protected override void AppendModule(TsModule module, ScriptBuilder sb, TsGeneratorOutput generatorOutput)
		{
			var classes = module.Classes.Where(c => !_typeConvertors.IsConvertorRegistered(c.Type) && !c.IsIgnored).ToList();
			var enums = module.Enums.Where(e => !_typeConvertors.IsConvertorRegistered(e.Type) && !e.IsIgnored).ToList();
			if ((generatorOutput == TsGeneratorOutput.Enums && enums.Count == 0) ||
				(generatorOutput == TsGeneratorOutput.Properties && classes.Count == 0) ||
				(enums.Count == 0 && classes.Count == 0))
			{
				return;
			}

			if ((generatorOutput & TsGeneratorOutput.Enums) == TsGeneratorOutput.Enums)
			{
				foreach (var enumModel in enums)
				{
					if (Ignore(enumModel)) continue;
					this.AppendEnumDefinition(enumModel, sb, generatorOutput);
				}
			}

			if (((generatorOutput & TsGeneratorOutput.Properties) == TsGeneratorOutput.Properties)
				|| (generatorOutput & TsGeneratorOutput.Fields) == TsGeneratorOutput.Fields)
			{
				foreach (var classModel in classes)
				{
					var c = ReMapClass(classModel);
					if (Ignore(c)) continue;
					this.AppendClassDefinition(c, sb, generatorOutput);
				}
			}

			if ((generatorOutput & TsGeneratorOutput.Constants) == TsGeneratorOutput.Constants)
			{
				foreach (var classModel in classes)
				{
					if (classModel.IsIgnored)
					{
						continue;
					}

					this.AppendConstantModule(classModel, sb);
				}
			}
		}

		protected bool Ignore(TsClass classModel)
		{
			if (this.TypeRenames.ContainsKey(classModel.Name)) return false;
			if (typeof(IRequestParameters).IsAssignableFrom(classModel.Type)) return true;
			if (IsClrType(classModel.Type)) return true;
			return false;
		}

		protected bool Ignore(TsEnum enumModel) => IsClrType(enumModel.Type);

		protected bool IsClrType(Type type)
		{
			var name = type.FullName ?? type.DeclaringType?.FullName;
			if (name != null && !name.StartsWith("Nest.") && !name.StartsWith("Elasticsearch.Net."))
				return true;
			return false;
		}

		protected TsClass ReMapClass(TsClass classModel)
		{
			if (typeof(RequestBase<>) == classModel.Type)
				return new TsClass(typeof(Request));

			if (typeof(ResponseBase) == classModel.Type)
				return new TsClass(typeof(Response));

			if (classModel.BaseType != null)
			{
				if (typeof(IRequest).IsAssignableFrom(classModel.BaseType.Type))
					classModel.BaseType = new TsClass(typeof(Request));

				if (classModel.BaseType.Type == typeof(ResponseBase))
					classModel.BaseType = new TsClass(typeof(Response));
			}

			return classModel;
		}
	}
	public class Request { }
	public class Response { }
}
