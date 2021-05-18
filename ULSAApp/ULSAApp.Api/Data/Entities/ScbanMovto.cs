using System;
using System.Collections.Generic;

#nullable disable

namespace ULSAApp.Api.Data.Entities
{
    public partial class ScbanMovto
    {
        public short C0ctaMov { get; set; }
        public DateTime C0fecmov { get; set; }
        public int C0renmov { get; set; }
        public int C0tipmov { get; set; }
        public int C0numcon { get; set; }
        public int C0nummat { get; set; }
        public int C0numref { get; set; }
        public string C0nompza { get; set; }
        public short? C0numpza { get; set; }
        public short? C0numsuc { get; set; }
        public string C0idemov { get; set; }
        public decimal? C0impmov { get; set; }
        public decimal? C0imprec { get; set; }
        public decimal? C0impnet { get; set; }
        public string C0sacmov { get; set; }
        public string C0forpag { get; set; }
        public string C0nombre { get; set; }
    }
}
