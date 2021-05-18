using System;
using System.Collections.Generic;

#nullable disable

namespace ULSAApp.Api.Data.Entities
{
    public partial class Sccalend
    {
        public byte F0numniv { get; set; }
        public int F0aciclo { get; set; }
        public double? F0numpe1 { get; set; }
        public double? F0numpe2 { get; set; }
        public double? F0numpe3 { get; set; }
        public double? F0numpe4 { get; set; }
        public double? F0numpe5 { get; set; }
        public double? F0numpe6 { get; set; }
        public double? F0numpe7 { get; set; }
        public double? F0numpe8 { get; set; }
        public double? F0numpe9 { get; set; }
        public double? F0nump10 { get; set; }
        public double? F0nump11 { get; set; }
        public double? F0nump12 { get; set; }

        public virtual ScnivAcad F0numnivNavigation { get; set; }
    }
}
