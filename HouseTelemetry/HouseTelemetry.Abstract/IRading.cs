using System;

namespace HouseTelemetry.Abstract
{
	public interface IRading
	{
		DateTime Date { get; set; }
		double Value { get; set; }
	}
}