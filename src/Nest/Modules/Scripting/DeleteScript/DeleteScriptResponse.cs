﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nest252
{
	public interface IDeleteScriptResponse : IAcknowledgedResponse { }

	public class DeleteScriptResponse : AcknowledgedResponseBase, IDeleteScriptResponse { }
}
