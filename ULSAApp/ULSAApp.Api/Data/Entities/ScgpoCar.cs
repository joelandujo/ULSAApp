using System;
using System.Collections.Generic;

#nullable disable

namespace ULSAApp.Api.Data.Entities
{
    public partial class ScgpoCar
    {
        public ScgpoCar()
        {
            Scalumnos = new HashSet<Scalumno>();
            Scprospecs = new HashSet<Scprospec>();
        }

        public int D0numgpo { get; set; }
        public string D0nomgpo { get; set; }
        public byte? D0numniv { get; set; }
        public double? D0codadm { get; set; }
        public double? D0impadm { get; set; }
        public string D0senadm { get; set; }
        public double? D0valadm { get; set; }
        public byte? D0codins { get; set; }
        public double? D0impins { get; set; }
        public string D0senins { get; set; }
        public double? D0valins { get; set; }
        public byte? D0codseg { get; set; }
        public double? D0impseg { get; set; }
        public string D0senseg { get; set; }
        public double? D0valseg { get; set; }
        public byte? D0codmat { get; set; }
        public double? D0impmat { get; set; }
        public string D0senmat { get; set; }
        public double? D0valmat { get; set; }
        public byte? D0codlib { get; set; }
        public double? D0implib { get; set; }
        public string D0senlib { get; set; }
        public double? D0vallib { get; set; }
        public double? D0codot1 { get; set; }
        public double? D0impot1 { get; set; }
        public string D0senot1 { get; set; }
        public double? D0valot1 { get; set; }
        public double? D0codot2 { get; set; }
        public double? D0impot2 { get; set; }
        public string D0senot2 { get; set; }
        public double? D0valot2 { get; set; }
        public byte? D0codcol { get; set; }
        public double? D0impcol { get; set; }
        public string D0sencol { get; set; }
        public double? D0valcol { get; set; }
        public byte? D0codtra { get; set; }
        public double? D0imptra { get; set; }
        public string D0sentra { get; set; }
        public double? D0valtra { get; set; }
        public double? D0dialim { get; set; }
        public double? D0dialr1 { get; set; }
        public double? D0dialr2 { get; set; }
        public string D0nomcor { get; set; }
        public double? D0numsem { get; set; }
        public string D0rvoegpo { get; set; }

        public virtual ScnivAcad D0numnivNavigation { get; set; }
        public virtual ICollection<Scalumno> Scalumnos { get; set; }
        public virtual ICollection<Scprospec> Scprospecs { get; set; }
    }
}
