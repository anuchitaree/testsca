using System;
using System.Collections.Generic;

namespace testsca.Models
{
    public partial class AssyAirLeakTest
    {
        public double Id { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public double Pallet { get; set; }
        public double Model { get; set; }
        public double CylinderSerialNo { get; set; }
        public double AirSupplyPressureLow { get; set; }
        public double LeakAtLowPressure { get; set; }
        public double AirSupplyPressureHigh { get; set; }
        public string Judgement { get; set; } = null!;
        public string Partnumber { get; set; } = null!;
        public double LeakAtHighPressure { get; set; }
        public string? F14 { get; set; }
        public string? F15 { get; set; }
        public string? F16 { get; set; }
        public string? CylinderSerialNoNew { get; set; }
    }
}
