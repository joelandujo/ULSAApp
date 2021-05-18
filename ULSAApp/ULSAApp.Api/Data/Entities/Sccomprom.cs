using System;
using System.Collections.Generic;

#nullable disable

namespace ULSAApp.Api.Data.Entities
{
    public partial class Sccomprom
    {
        public int K0folio { get; set; }
        public int K0nummat { get; set; }
        public DateTime K0feccom { get; set; }
        public DateTime? K0fecdia { get; set; }
        public double? K0import { get; set; }
        public string K0comen1 { get; set; }
        public string K0comen2 { get; set; }
        public string K0comen3 { get; set; }
        public string K0nomalu { get; set; }
    }
}
