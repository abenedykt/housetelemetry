using System.Collections.Generic;

namespace HouseTelemetry.Abstract
{
	public interface IHouseTelemetry
	{
		IEnumerable<ISensor> AllSensors();
		IEnumerable<ISensorReading> DailyStat();
	}
}