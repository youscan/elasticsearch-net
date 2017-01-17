using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nest252
{
	public partial interface IDeleteLicenseRequest
	{
	}

	public partial class DeleteLicenseRequest
	{
	}

	[DescriptorFor("LicenseDelete")]
	public partial class DeleteLicenseDescriptor : IDeleteLicenseRequest
	{

	}
}
