using HouseTelemetry.Abstract;

namespace HouseTelemetry.Core
{
	public class SensorReading : ISensorReading
	{
		public SensorReading()
		{
			Sensor = new Sensor();
			Value = new Reading();
		}

		public ISensor Sensor { get; set; }
		public IReading Value { get; set; }
	}
}