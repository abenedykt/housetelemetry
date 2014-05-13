using System;

namespace HouseTelemetry.Abstract
{
	public interface IReading
	{
		DateTime Date { get; set; }
		double Value { get; set; }
	}
}