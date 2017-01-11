namespace Nest500
{
	public class PercolatorAttribute : ElasticsearchPropertyAttributeBase, IPercolatorProperty
	{
		public PercolatorAttribute() : base("percolator") { }
	}
}
