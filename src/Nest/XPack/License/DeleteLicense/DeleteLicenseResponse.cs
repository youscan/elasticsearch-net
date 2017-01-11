using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nest500
{
	public interface IDeleteLicenseResponse : IResponse { }

	public class DeleteLicenseResponse : ResponseBase, IDeleteLicenseResponse { }
}
