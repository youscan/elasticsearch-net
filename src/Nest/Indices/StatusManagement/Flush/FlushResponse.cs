using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nest252
{
	public interface IFlushResponse : IShardsOperationResponse { }
	
	public class FlushResponse : ShardsOperationResponseBase, IFlushResponse { }
}
