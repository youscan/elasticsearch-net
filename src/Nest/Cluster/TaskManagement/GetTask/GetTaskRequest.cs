using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nest500
{
	public partial interface IGetTaskRequest { }

	public partial class GetTaskRequest { }

	[DescriptorFor("TasksGet")]
	public partial class GetTaskDescriptor { }
}
