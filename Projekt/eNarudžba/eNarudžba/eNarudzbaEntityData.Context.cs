﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class T34_DBEntities2 : DbContext
    {
        public T34_DBEntities2()
            : base("name=T34_DBEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Hrana> Hrana { get; set; }
        public virtual DbSet<HranaSastojci> HranaSastojci { get; set; }
        public virtual DbSet<Korisnik> Korisnik { get; set; }
        public virtual DbSet<Narudzba> Narudzba { get; set; }
        public virtual DbSet<NarudzbaHrana> NarudzbaHrana { get; set; }
        public virtual DbSet<NarudzbaPice> NarudzbaPice { get; set; }
        public virtual DbSet<NarudzbaStatus> NarudzbaStatus { get; set; }
        public virtual DbSet<Pice> Pice { get; set; }
        public virtual DbSet<Placanje> Placanje { get; set; }
        public virtual DbSet<Sastojci> Sastojci { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TipKorisnika> TipKorisnika { get; set; }
        public virtual DbSet<VelicinaHrane> VelicinaHrane { get; set; }
    }
}
