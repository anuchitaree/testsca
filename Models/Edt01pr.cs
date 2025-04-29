using System;
using System.Collections.Generic;

namespace testsca.Models
{
    public partial class Edt01pr
    {
        public double Id { get; set; }
        public double Cusno { get; set; }
        public double Shpno { get; set; }
        public string Model { get; set; } = null!;
        public double Duedt { get; set; }
        public string Corno { get; set; } = null!;
        public string Cuspo { get; set; } = null!;
        public string Lotno { get; set; } = null!;
        public double Orqty { get; set; }
        public string Oqflg { get; set; } = null!;
        public string Mpflg { get; set; } = null!;
        public string Cfmno { get; set; } = null!;
    }
}
