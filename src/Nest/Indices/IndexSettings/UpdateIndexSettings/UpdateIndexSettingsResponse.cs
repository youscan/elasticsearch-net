using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nest500
{
	public interface IUpdateIndexSettingsResponse : IAcknowledgedResponse { }

	public class UpdateIndexSettingsResponse : AcknowledgedResponseBase, IUpdateIndexSettingsResponse { }
}
