namespace Nest500
{
	public class GeoBoundsAggregate : MetricAggregateBase
	{
		public GeoBoundsAggregate()
		{
			Bounds = new GeoBounds();
		}

		public GeoBounds Bounds { get; set; }
	}

	public class GeoBounds
	{
		public LatLon TopLeft { get; set; }
		public LatLon BottomRight { get; set; }
	}
}
