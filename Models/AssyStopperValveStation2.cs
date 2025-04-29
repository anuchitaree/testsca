using System;
using System.Collections.Generic;

namespace testsca.Models
{
    public partial class AssyStopperValveStation2
    {
        public double Id { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public double Pallet { get; set; }
        public double Model { get; set; }
        public string CylinderSerialNo { get; set; } = null!;
        public double StopperValveServoPress { get; set; }
        public double Reserve { get; set; }
        public double StopperValvePress { get; set; }
        public double DimensionCheckAfterPressFit { get; set; }
        public string Judgement { get; set; } = null!;
        public string Partnumber { get; set; } = null!;
    }
}
