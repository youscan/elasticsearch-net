namespace Nest500
{
	internal class CreateJsonConverter : DocumentJsonConverterBase<ICreateRequest>
	{
		public CreateJsonConverter() : base(typeof(CreateRequest<>)) { }
	}
}
