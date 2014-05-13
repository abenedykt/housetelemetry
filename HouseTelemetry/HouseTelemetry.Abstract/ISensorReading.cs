namespace HouseTelemetry.Abstract
{
	public interface ISensorReading
	{
		ISensor Sensor { get; set; }
		IRading Reading { get; set; }
	}
}