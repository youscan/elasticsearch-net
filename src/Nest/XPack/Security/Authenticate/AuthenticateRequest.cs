using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nest500
{
	public partial interface IAuthenticateRequest
	{
	}

	public partial class AuthenticateRequest
	{
	}

	[DescriptorFor("XpackSecurityAuthenticate")]
	public partial class AuthenticateDescriptor
	{
	}
}
