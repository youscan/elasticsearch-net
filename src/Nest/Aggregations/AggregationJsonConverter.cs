﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nest500
{
	internal class AggregationJsonConverter<TReadAs> : ReadAsTypeJsonConverter<TReadAs>
		where TReadAs : class
	{ }
}
