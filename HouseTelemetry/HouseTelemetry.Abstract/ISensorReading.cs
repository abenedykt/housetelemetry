namespace HouseTelemetry.Abstract
{
	public interface ISensorReading
	{
		ISensor Sensor { get; set; }
		IReading Value { get; set; }
	}
}