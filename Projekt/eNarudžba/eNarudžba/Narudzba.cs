//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eNarudžba
{
    using System;
    using System.Collections.Generic;
    
    public partial class Narudzba
    {
        public Narudzba()
        {
            this.NarudzbaHrana = new HashSet<NarudzbaHrana>();
            this.NarudzbaPice = new HashSet<NarudzbaPice>();
            this.NarudzbaStatus = new HashSet<NarudzbaStatus>();
        }
    
        public int IDnarudzba { get; set; }
        public System.DateTime DatumVrijemeZaprimanja { get; set; }
        public decimal CijenaNarudzbe { get; set; }
        public long IDnarucitelj { get; set; }
        public int IDplacanje { get; set; }
        public Nullable<int> IDstatus { get; set; }
        public Nullable<int> IDpice { get; set; }
        public Nullable<int> IDhrana { get; set; }
    
        public virtual Korisnik Korisnik { get; set; }
        public virtual Placanje Placanje { get; set; }
        public virtual ICollection<NarudzbaHrana> NarudzbaHrana { get; set; }
        public virtual ICollection<NarudzbaPice> NarudzbaPice { get; set; }
        public virtual ICollection<NarudzbaStatus> NarudzbaStatus { get; set; }
    }
}
