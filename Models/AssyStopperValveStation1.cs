using System;
using System.Collections.Generic;

namespace testsca.Models
{
    public partial class AssyStopperValveStation1
    {
        public double Id { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public double Pallet { get; set; }
        public double Model { get; set; }
        public string CylinderSerialNo { get; set; } = null!;
        public double MonthChar { get; set; }
        public string YearChar { get; set; } = null!;
        public string HSerialNo { get; set; } = null!;
        public double DimensionBallSpringCheck { get; set; }
        public string Judgement { get; set; } = null!;
        public string Partnumber { get; set; } = null!;
        public string? F14 { get; set; }
        public string? F15 { get; set; }
        public string? F16 { get; set; }
    }
}
