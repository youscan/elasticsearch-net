using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nest500
{
	public class BlockState
	{
		[JsonProperty("read_only")]
		public bool ReadOnly { get; set; }
	}
}