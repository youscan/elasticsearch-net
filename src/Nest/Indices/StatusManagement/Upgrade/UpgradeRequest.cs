using Elasticsearch252.Net;

namespace Nest252
{
	public partial interface IUpgradeRequest : IRequest<UpgradeRequestParameters> { }

	public partial class UpgradeRequest { }

	[DescriptorFor("IndicesUpgrade")]
	public partial class UpgradeDescriptor { }
}
