using System;
using System.Collections.Generic;

#nullable disable

namespace ULSAApp.Api.Data.Entities
{
    public partial class Scescuela
    {
        public Scescuela()
        {
            Scprospecs = new HashSet<Scprospec>();
        }

        public int Q0codesc { get; set; }
        public string Q0nomesc { get; set; }

        public virtual ICollection<Scprospec> Scprospecs { get; set; }
    }
}
