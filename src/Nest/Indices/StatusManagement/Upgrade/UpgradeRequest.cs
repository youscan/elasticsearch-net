using Elasticsearch500.Net;

namespace Nest500
{
	public partial interface IUpgradeRequest : IRequest<UpgradeRequestParameters> { }

	public partial class UpgradeRequest { }

	[DescriptorFor("IndicesUpgrade")]
	public partial class UpgradeDescriptor { }
}
