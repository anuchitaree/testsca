using System;
using System.Collections.Generic;

namespace testsca.Models
{
    public partial class Qrshippinglog
    {
        public double Id { get; set; }
        public double? Seq { get; set; }
        public string? WH { get; set; }
        public double? DevId { get; set; }
        public string? Sysflg1 { get; set; }
        public string? Sysflg2 { get; set; }
        public string? Sysflg3 { get; set; }
        public string? Sysflg4 { get; set; }
        public string? LoginId { get; set; }
        public double? TrDateYmd { get; set; }
        public double? TrType { get; set; }
        public string? OpeSeq { get; set; }
        public double? Result { get; set; }
        public double? RsnCode { get; set; }
        public string? TruckNo { get; set; }
        public double? CustNo { get; set; }
        public string? ShipNo { get; set; }
        public double? CheckType { get; set; }
        public string? ShipPN { get; set; }
        public string? ShipQty { get; set; }
        public string? TagType { get; set; }
        public string? PN { get; set; }
        public string? CustPN { get; set; }
        public string? Qty { get; set; }
        public string? TagSeq { get; set; }
        public double? ScanDateYmd { get; set; }
        public double? ScanTime { get; set; }
    }
}
