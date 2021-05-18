using System;
using System.Collections.Generic;

#nullable disable

namespace ULSAApp.Api.Data.Entities
{
    public partial class Scformato
    {
        public Scformato()
        {
            ScforDets = new HashSet<ScforDet>();
        }

        public string H0nomfrm { get; set; }
        public string H0desfrm { get; set; }
        public string H0tiplet { get; set; }
        public string H0tipimp { get; set; }
        public string H0lastfr { get; set; }
        public string H0idedoc { get; set; }
        public string H0modulo { get; set; }
        public string H0tipfor { get; set; }

        public virtual ICollection<ScforDet> ScforDets { get; set; }
    }
}
