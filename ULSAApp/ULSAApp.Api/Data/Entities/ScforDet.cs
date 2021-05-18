using System;
using System.Collections.Generic;

#nullable disable

namespace ULSAApp.Api.Data.Entities
{
    public partial class ScforDet
    {
        public string G04nomfrm { get; set; }
        public double G04rowpos { get; set; }
        public double G04colpos { get; set; }
        public string G04descrp { get; set; }
        public string G04campo { get; set; }
        public int? G04longit { get; set; }
        public int? G04lindat { get; set; }
        public string G04pictur { get; set; }
        public string G04const { get; set; }

        public virtual Scformato G04nomfrmNavigation { get; set; }
    }
}
