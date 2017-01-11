using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Nest500
{
	public interface IDeleteUserResponse : IResponse
	{
		[JsonProperty("found")]
		bool Found { get; }
	}

	public class DeleteUserResponse : ResponseBase, IDeleteUserResponse
	{
		public bool Found { get; internal set; }
	}
}
