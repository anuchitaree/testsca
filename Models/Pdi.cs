using System;
using System.Collections.Generic;

namespace testsca.Models
{
    public partial class Pdi
    {
        public double Id { get; set; }
        public double RowInOriginalSheet { get; set; }
        public string MergedText { get; set; } = null!;
        public string PartsNo { get; set; } = null!;
        public string? PartsName { get; set; }
        public string Pcnumber { get; set; } = null!;
        public string? SupplierCode { get; set; }
        public double TagSerialNo { get; set; }
        public string CustomerNo { get; set; } = null!;
        public double Qty { get; set; }
        public string TraceLotNo { get; set; } = null!;
        public string FromProCode { get; set; } = null!;
        public string? DeliveryDate { get; set; }
        public DateTime SystemDate { get; set; }
        public string? SupplierLotno { get; set; }
        public string? SupplierPartsNo { get; set; }
        public double TotalQty { get; set; }
        public double Box { get; set; }
        public double TotalBox { get; set; }
        public string? IssueNo { get; set; }
        public string NextProCode { get; set; } = null!;
        public double Fraction { get; set; }
        public double Prev1ProPartsNo { get; set; }
        public string Prev1ProLotNo { get; set; } = null!;
        public string? Prev1ProCode { get; set; }
        public string? Prev2ProPartsNo { get; set; }
        public string? Prev2ProLotNo { get; set; }
        public string? Prev2ProCode { get; set; }
        public double AssociateNo { get; set; }
        public string SiftCode { get; set; } = null!;
        public string? _5mecode { get; set; }
        public DateTime WorkingDate { get; set; }
        public string ProcessCode { get; set; } = null!;
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
        public string? LineCode { get; set; }
        public double Nmark { get; set; }
        public string? Nextprocessname { get; set; }
        public string? FractionLotNo { get; set; }
        public string? FractionQty { get; set; }
        public double ReissueFlg { get; set; }
        public double PrintQty { get; set; }
        public string ActualReadTime { get; set; } = null!;
    }
}
