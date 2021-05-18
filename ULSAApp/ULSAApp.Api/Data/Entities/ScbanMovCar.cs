using System;
using System.Collections.Generic;

#nullable disable

namespace ULSAApp.Api.Data.Entities
{
    public partial class ScbanMovCar
    {
        public short D0ctaMov { get; set; }
        public DateTime D0fecmov { get; set; }
        public int D0renmov { get; set; }
        public int D0tipmov { get; set; }
        public int D0nummat { get; set; }
        public int D0conmov { get; set; }
        public long D0refmov { get; set; }
        public decimal D0impmov { get; set; }
        public decimal? D0bonmov { get; set; }
        public string D0seamov { get; set; }
        public string D0sacmov { get; set; }
        public string D0FpaMov { get; set; }
        public int? D0folrec { get; set; }
    }
}
