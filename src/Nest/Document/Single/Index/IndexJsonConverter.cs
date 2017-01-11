namespace Nest500
{
	internal class IndexJsonConverter : DocumentJsonConverterBase<IIndexRequest>
	{
		public IndexJsonConverter() : base(typeof(IndexRequest<>)) { }
	}
}
