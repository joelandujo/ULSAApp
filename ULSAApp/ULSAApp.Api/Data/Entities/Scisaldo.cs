using System;
using System.Collections.Generic;

#nullable disable

namespace ULSAApp.Api.Data.Entities
{
    public partial class Scisaldo
    {
        public byte I0numniv { get; set; }
        public int I0numgpo { get; set; }
        public int I0nummat { get; set; }
        public byte I0numcon { get; set; }
        public int I0numref { get; set; }
        public int I0consec { get; set; }
        public DateTime? I0fecope { get; set; }
        public DateTime? I0fecpag { get; set; }
        public double? I0import { get; set; }
        public double? I0salact { get; set; }
        public double? I0salrec { get; set; }
        public DateTime? I0ultrec { get; set; }
        public string I0senaux { get; set; }
        public string I0senrec { get; set; }
        public string I0nomalu { get; set; }
        public double? I0imppag { get; set; }
        public double? I0tascpp { get; set; }
        public int? I0ncontr { get; set; }
        public DateTime? I0fecuci { get; set; }
        public DateTime? I0fecven { get; set; }
        public int? I0refcar { get; set; }
        public short? I0codtcp { get; set; }
    }
}
