﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB_TECres
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TECresEntities1 : DbContext
    {
        public TECresEntities1()
            : base("name=TECresEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ADMINISTRADOR> ADMINISTRADOR { get; set; }
        public virtual DbSet<ANUNCIO> ANUNCIO { get; set; }
        public virtual DbSet<CLIENTE> CLIENTE { get; set; }
        public virtual DbSet<COMPRADOR> COMPRADOR { get; set; }
        public virtual DbSet<FACTURA> FACTURA { get; set; }
        public virtual DbSet<FOTO> FOTO { get; set; }
        public virtual DbSet<MENSAJE> MENSAJE { get; set; }
        public virtual DbSet<OCUPACION> OCUPACION { get; set; }
        public virtual DbSet<PERFIL_DE_CLIENTE> PERFIL_DE_CLIENTE { get; set; }
        public virtual DbSet<PROPIEDAD> PROPIEDAD { get; set; }
        public virtual DbSet<PUBLICO_META> PUBLICO_META { get; set; }
        public virtual DbSet<TIENE_OCUPACION> TIENE_OCUPACION { get; set; }
        public virtual DbSet<TIENE_PISO> TIENE_PISO { get; set; }
        public virtual DbSet<TIPO_ANUNCIO> TIPO_ANUNCIO { get; set; }
        public virtual DbSet<TIPO_INMUEBLE> TIPO_INMUEBLE { get; set; }
        public virtual DbSet<TIPO_PISO> TIPO_PISO { get; set; }
        public virtual DbSet<UBICACION> UBICACION { get; set; }
        public virtual DbSet<VENDEDOR> VENDEDOR { get; set; }
    }
}
