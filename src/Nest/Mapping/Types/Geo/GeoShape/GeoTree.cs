﻿using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Nest500
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum GeoTree
	{
		[EnumMember(Value = "geohash")]
		Geohash,
		[EnumMember(Value = "quadtree")]
		Quadtree
	}
}
