using System;
using System.Collections.Generic;

#nullable disable

namespace ULSAApp.Api.Data.Entities
{
    public partial class ScdisEfectivo
    {
        public int M0numtra { get; set; }
        public int M0folrec { get; set; }
        public DateTime M0fectra { get; set; }
        public double? M0impefe { get; set; }
        public string M0desch1 { get; set; }
        public double? M0impch1 { get; set; }
        public string M0desch2 { get; set; }
        public double? M0impch2 { get; set; }
        public string M0destc1 { get; set; }
        public double? M0imptc1 { get; set; }
        public string M0destc2 { get; set; }
        public double? M0imptc2 { get; set; }
        public double? M0recant { get; set; }
        public double? M0imprec { get; set; }
        public double? M0totpag { get; set; }
        public double? M0adeudo { get; set; }
        public double? M0cambio { get; set; }
    }
}
