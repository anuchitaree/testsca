using System;
using System.Collections.Generic;

namespace testsca.Models
{
    public partial class Ed000pr
    {
        public double Id { get; set; }
        public double Cusno { get; set; }
        public double Shpno { get; set; }
        public string Prtno { get; set; } = null!;
        public double Duedt { get; set; }
        public string Corno { get; set; } = null!;
        public string Cprtn { get; set; } = null!;
        public double Ogqty { get; set; }
        public double Orqty { get; set; }
        public double Alqty { get; set; }
        public double Shdqy { get; set; }
        public double Shpdt { get; set; }
        public double Noshp { get; set; }
        public double Kbflg { get; set; }
        public double Odrfl { get; set; }
        public string Sorno { get; set; } = null!;
        public string Spodf { get; set; } = null!;
        public string Model { get; set; } = null!;
        public string Cuspo { get; set; } = null!;
        public string Lotno { get; set; } = null!;
        public double Lmndt { get; set; }
    }
}
