﻿using System;
using System.Collections.ObjectModel;
using System.Reflection;
using Elasticsearch500.Net;
using Newtonsoft.Json;

namespace Nest500
{
	public interface IConnectionSettingsValues : IConnectionConfigurationValues
	{
		Inferrer Inferrer { get; }
		FluentDictionary<Type, string> DefaultIndices { get; }
		FluentDictionary<Type, string> DefaultTypeNames { get; }
		FluentDictionary<Type, string> IdProperties { get; }
		FluentDictionary<MemberInfo, IPropertyMapping> PropertyMappings { get; }
		string DefaultIndex { get; }
		Func<string, string> DefaultFieldNameInferrer { get; }
		Func<Type, string> DefaultTypeNameInferrer { get; }

		ISerializerFactory SerializerFactory { get; }

		IElasticsearchSerializer StatefulSerializer(JsonConverter converter);
	}
}
