using System;
using HouseTelemetry.Abstract;

namespace HouseTelemetry.Core
{
	public class Reading : IReading
	{
		public DateTime Date { get; set; }
		public double Value { get; set; }
	}
}