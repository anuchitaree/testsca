using System;
using System.Collections.Generic;

namespace testsca.Models
{
    public partial class AssyOilSealPressFitting
    {
        public double Id { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public double Pallet { get; set; }
        public double Model { get; set; }
        public string CylinderSerialNo { get; set; } = null!;
        public double Press { get; set; }
        public string OilSeal { get; set; } = null!;
        public string Judgement { get; set; } = null!;
        public string Partnumber { get; set; } = null!;
    }
}
