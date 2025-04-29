using testsca.Models;
using testsca.Output;

namespace testsca.Classes
{
    public static  class SearchFn
    {

        public static List<Pdiout> PDI_search_Tag_serial(string TagSerialNo)
        {
            List<Pdiout> pditable = new List<Pdiout>();

            using (var db = new scaContext())
            {
                var tag = Convert.ToDouble(TagSerialNo);
                pditable = db.Pdis.Where(x => x.TagSerialNo == tag)
                        .Select(x => new Pdiout
                        {
                            Id = x.Id,
                            TagSerialNo = Convert.ToInt32(x.TagSerialNo),
                            PartsNo = x.PartsNo,
                            FinishGoodsNo = x.Prev1ProLotNo,
                            Pcnumber = x.Pcnumber,

                            TotalQty = Convert.ToInt32(x.TotalQty),
                            SystemDate = x.SystemDate,

                            //CustomerNo = x.CustomerNo,
                            //Qty = Convert.ToInt32( x.Qty),
                            //TraceLotNo = x.TraceLotNo,
                            //TotalBox= Convert.ToInt32(x.TotalBox),
                            //Box= Convert.ToInt32(x.Box),
                            //AssociateNo = Convert.ToInt32(x.AssociateNo),
                            //SiftCode = x.SiftCode,
                        }).ToList();
            }
            return pditable;
        }
        public static List<Pdiout> PDI_search_finishgoods(string FinishGoodsNo)
        {
            List<Pdiout> pditable = new List<Pdiout>();

            using (var db = new scaContext())
            {
                pditable = db.Pdis.Where(x => x.Prev1ProLotNo == FinishGoodsNo)
                        .Select(x => new Pdiout
                        {
                            Id = x.Id,
                            TagSerialNo = Convert.ToInt32(x.TagSerialNo),
                            PartsNo = x.PartsNo,
                            FinishGoodsNo = x.Prev1ProLotNo,
                            Pcnumber = x.Pcnumber,

                            TotalQty = Convert.ToInt32(x.TotalQty),
                            SystemDate = x.SystemDate,
                        }).ToList();
            }
            return pditable;
        }


        public static List<FinalOut> Final_search_finishgoods(string FinishGoodsNo)
        {
            List<FinalOut> finalOut = new List<FinalOut>();

            using (var db = new scaContext())
            {
                finalOut = db.FinalInspectionMatchSerials.Where(x => x.DataSn1CutFromI == FinishGoodsNo)
                        .Select(x => new FinalOut
                        {
                            Id = x.Id,
                            DensoPartNoPumpPartNumber = x.DensoPartNoPumpPartNumber,
                            FinishGoodsNo = x.DataSn1CutFromI,
                            CylinderSerialNo = x.CylinderSerialCutFromJ,
                            Datetime = x.Datetime
                        }).ToList();
            }
            return finalOut;
        }
        public static List<FinalOut> Final_search_cylinderserialno(string Cylinderserialno)
        {
            List<FinalOut> finalOut = new List<FinalOut>();

            using (var db = new scaContext())
            {
                finalOut = db.FinalInspectionMatchSerials.Where(x => x.CylinderSerialCutFromJ == Cylinderserialno)
                        .Select(x => new FinalOut
                        {
                            Id = x.Id,
                            DensoPartNoPumpPartNumber = x.DensoPartNoPumpPartNumber,
                            FinishGoodsNo = x.DataSn1CutFromI,
                            CylinderSerialNo = x.CylinderSerialCutFromJ,
                            Datetime = x.Datetime
                        }).ToList();
            }
            return finalOut;
        }

        public static List<InspectionOut> Inspection_search_cylinderserialno(string Cylinderserialno)
        {
            List<InspectionOut> inspOut = new List<InspectionOut>();

            using (var db = new scaContext())
            {
                inspOut = db.Inspections.Where(x => x.SerialNo == Cylinderserialno)
                        .Select(x => new InspectionOut
                        {
                            Id = x.Id,
                            DeviceTimestamp = x.DeviceTimestamp,
                            Model = x.Model,
                            SerialNo = x.SerialNo,
                        }).ToList();
            }
            return inspOut;
        }

        public static List<GrindingnOut> Grinding_search_cylinderserialno(string Cylinderserialno)
        {
            List<GrindingnOut> Out = new List<GrindingnOut>();

            using (var db = new scaContext())
            {
                Out = db.CylinderGrindings.Where(x => x.SerialNo == Cylinderserialno)
                        .Select(x => new GrindingnOut
                        {
                            Id = x.Id,
                           DateTime = x.DateTime,
                            Model = x.Model,
                            SerialNo = x.SerialNo,
                        }).ToList();
            }
            return Out;
        }
    }
}
