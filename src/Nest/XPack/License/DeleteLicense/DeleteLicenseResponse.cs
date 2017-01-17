using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nest252
{
	public interface IDeleteLicenseResponse : IResponse
	{
	}

	public class DeleteLicenseResponse : ResponseBase, IDeleteLicenseResponse
	{
	}
}
