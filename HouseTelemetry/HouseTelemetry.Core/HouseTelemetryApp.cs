using System.Collections.Generic;
using HouseTelemetry.Abstract;

namespace HouseTelemetry.Core
{
    public class HouseTelemetryApp : IHouseTelemetry
    {
	    public IEnumerable<ISensor> AllSensors()
	    {
		    yield return new Sensor();
	    }

	    public IEnumerable<ISensorReading> DailyStat()
	    {
		    yield return new SensorReading();
		    yield return new SensorReading();
		    yield return new SensorReading();
		    yield return new SensorReading();
	    }
    }
}
