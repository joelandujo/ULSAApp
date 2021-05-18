using System;
using System.Collections.Generic;

#nullable disable

namespace ULSAApp.Api.Data.Entities
{
    public partial class Scanegociacione
    {
        public int N0folneg { get; set; }
        public DateTime? N0fecneg { get; set; }
        public int? N0matneg { get; set; }
        public string N0de1neg { get; set; }
        public string N0de2neg { get; set; }
        public short? N0codtcp { get; set; }
        public DateTime? N0nebneg { get; set; }
        public string N0stsneg { get; set; }
        public short? N0concar { get; set; }
        public short? N0congto { get; set; }
        public decimal? N0impgto { get; set; }
        public short? N0conint { get; set; }
        public decimal? N0impint { get; set; }
    }
}
