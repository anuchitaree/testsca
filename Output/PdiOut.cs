using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testsca.Output
{
     public  class Pdiout
    {
        public double Id { get; set; }
        public int TagSerialNo { get; set; }
        public string PartsNo { get; set; } = null!;
        public string FinishGoodsNo { get; set; } = null!;
        public int TotalQty { get; set; }
        public DateTime SystemDate { get; set; }


        public string Pcnumber { get; set; } = null!;
        //public string CustomerNo { get; set; } = null!;
        //public int Qty { get; set; }
        //public string TraceLotNo { get; set; } = null!;

        //public int Box { get; set; }
        //public int TotalBox { get; set; }

        //public int AssociateNo { get; set; }
        //public string SiftCode { get; set; } = null!;

    }
}
