using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nest500
{
	public interface ISyncedFlushResponse : IShardsOperationResponse { }

	public class SyncedFlushResponse : ShardsOperationResponseBase, ISyncedFlushResponse { }
}
