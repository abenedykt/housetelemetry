using HouseTelemetry.Abstract;

namespace HouseTelemetry.Core
{
	public class Sensor : ISensor
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Location { get; set; }
		public string Unit { get; set; }
	}
}