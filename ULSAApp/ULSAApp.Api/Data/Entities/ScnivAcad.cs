using System;
using System.Collections.Generic;

#nullable disable

namespace ULSAApp.Api.Data.Entities
{
    public partial class ScnivAcad
    {
        public ScnivAcad()
        {
            Sccalends = new HashSet<Sccalend>();
            ScgpoCars = new HashSet<ScgpoCar>();
        }

        public byte B0numniv { get; set; }
        public string B0nomniv { get; set; }
        public int? B0aciclo { get; set; }

        public virtual ICollection<Sccalend> Sccalends { get; set; }
        public virtual ICollection<ScgpoCar> ScgpoCars { get; set; }
    }
}
