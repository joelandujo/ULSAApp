using System;
using System.Collections.Generic;

#nullable disable

namespace ULSAApp.Api.Data.Entities
{
    public partial class Scprospec
    {
        public int P0codpro { get; set; }
        public int? P0nummat { get; set; }
        public string P0nompro { get; set; }
        public string P0nospro { get; set; }
        public string P0apppro { get; set; }
        public string P0apmpro { get; set; }
        public string P0dompro { get; set; }
        public string P0ciupro { get; set; }
        public string P0rfcpro { get; set; }
        public int? P0codcar { get; set; }
        public byte? P0numsem { get; set; }
        public int? P0codesc { get; set; }
        public string P0ColPro { get; set; }
        public string P0MunPro { get; set; }
        public string P0EdoPro { get; set; }
        public string P0PaiPro { get; set; }
        public int? P0CpoPro { get; set; }
        public string P0TelPro { get; set; }
        public string P0CurPro { get; set; }
        public string P0CelPro { get; set; }

        public virtual ScgpoCar P0codcarNavigation { get; set; }
        public virtual Scescuela P0codescNavigation { get; set; }
    }
}
