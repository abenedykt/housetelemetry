namespace HouseTelemetry.Abstract
{
	public interface ISensor
	{
		string Id { get; set; }
		string Name { get; set; }
		string Location { get; set; }
		string Unit { get; set; }
	}
}