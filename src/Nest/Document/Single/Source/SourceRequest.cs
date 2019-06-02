﻿namespace Nest
{
	[MapsApi("get_source.json")]
	public partial interface ISourceRequest { }

	// ReSharper disable UnusedTypeParameter
	public partial interface ISourceRequest<TDocument> where TDocument : class { }

	public partial class SourceRequest { }

	// ReSharper disable UnusedTypeParameter
	public partial class SourceRequest<TDocument> where TDocument : class { }

	public partial class SourceDescriptor<TDocument> where TDocument : class
	{
		public SourceDescriptor<TDocument> ExecuteOnPrimary() => Preference("_primary");

		public SourceDescriptor<TDocument> ExecuteOnLocalShard() => Preference("_local");
	}
}
