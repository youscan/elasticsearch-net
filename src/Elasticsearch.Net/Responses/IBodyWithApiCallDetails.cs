namespace Elasticsearch252.Net
{
	public interface IBodyWithApiCallDetails
	{
		IApiCallDetails CallDetails { get; set; }
	}
}