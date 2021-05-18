using System;
using System.Collections.Generic;

#nullable disable

namespace ULSAApp.Api.Data.Entities
{
    public partial class Scalumno
    {
        public int G0nummat { get; set; }
        public byte? G0numniv { get; set; }
        public int? G0numgpo { get; set; }
        public string G0tipbec { get; set; }
        public double? G0tiptra { get; set; }
        public double? G0portra { get; set; }
        public string G0situac { get; set; }
        public string G0seguro { get; set; }
        public DateTime? G0fecing { get; set; }
        public DateTime? G0fecbaj { get; set; }
        public string G0nomalu { get; set; }
        public string G0domic1 { get; set; }
        public string G0domic2 { get; set; }
        public string G0ciudad { get; set; }
        public string G0telefo { get; set; }
        public string G0alsexo { get; set; }
        public DateTime? G0fecnac { get; set; }
        public string G0rfcalu { get; set; }
        public string G0recesp { get; set; }
        public string G0nomrec { get; set; }
        public string G0domre1 { get; set; }
        public string G0domre2 { get; set; }
        public string G0ciurec { get; set; }
        public string G0telrec { get; set; }
        public string G0rfcrec { get; set; }
        public double? G0dadpag { get; set; }
        public string G0calmor { get; set; }
        public string G0appalu { get; set; }
        public string G0apmalu { get; set; }
        public string G0nosalu { get; set; }
        public byte? G0numsem { get; set; }
        public string G0ctacor { get; set; }
        public string G0sengra { get; set; }
        public DateTime? G0fecgra { get; set; }
        public string G0bonbec { get; set; }
        public int? G0matri1 { get; set; }
        public int? G0matri2 { get; set; }
        public int? G0matri3 { get; set; }
        public string G0peddat { get; set; }
        public string G0status { get; set; }
        public int? G0folneg { get; set; }
        public string G0fpaAlu { get; set; }
        public string G0banAlu { get; set; }
        public string G0cbaAlu { get; set; }
        public string G0celAlu { get; set; }
        public int? G0cpoAlu { get; set; }
        public string G0munAlu { get; set; }
        public string G0edoAlu { get; set; }
        public string G0paiAlu { get; set; }
        public int? G0cpoRec { get; set; }
        public string G0munRec { get; set; }
        public string G0edoRec { get; set; }
        public string G0paiRec { get; set; }
        public string G0curAlu { get; set; }
        public short? G0mpaAlu { get; set; }
        public string G0passApp { get; set; }

        public virtual ScgpoCar G0numgpoNavigation { get; set; }
    }
}
