using System;
using System.Collections.Generic;

#nullable disable

namespace ULSAApp.Api.Data.Entities
{
    public partial class ScfaceleAnt
    {
        public byte FenumNiv { get; set; }
        public int Fenumgpo { get; set; }
        public int Fenummat { get; set; }
        public DateTime Fefecrec { get; set; }
        public string FeserRec { get; set; }
        public int Fefolrec { get; set; }
        public decimal? Fetotrec { get; set; }
        public string FefacSts { get; set; }
        public string FefacArc { get; set; }
        public string FefacUuid { get; set; }
        public DateTime? FefacFeT { get; set; }
        public string FefacCfdi { get; set; }
        public string FefacSat { get; set; }
        public string FefacSer { get; set; }
        public string FefacXml { get; set; }
        public string FefacRfce { get; set; }
        public string FefacRfcr { get; set; }
        public string FefacErr { get; set; }
        public string FetipDoc { get; set; }
        public string FetipIng { get; set; }
    }
}
