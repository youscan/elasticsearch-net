﻿using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Nest252
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum GapPolicy
	{
		[EnumMember(Value = "skip")]
		Skip,
		[EnumMember(Value = "insert_zeros")]
		InsertZeros
	}
}
