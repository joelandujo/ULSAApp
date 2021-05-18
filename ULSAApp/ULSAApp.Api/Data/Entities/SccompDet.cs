using System;
using System.Collections.Generic;

#nullable disable

namespace ULSAApp.Api.Data.Entities
{
    public partial class SccompDet
    {
        public int K1folio { get; set; }
        public int K1pagNum { get; set; }
        public DateTime? K1pagFec { get; set; }
        public decimal? K1pagImp { get; set; }
    }
}
