﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BandasWeb
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Database1Entities1 : DbContext
    {
        public Database1Entities1()
            : base("name=Database1Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Carac_sala> Carac_sala { get; set; }
        public virtual DbSet<Caracteristicas> Caracteristicas { get; set; }
        public virtual DbSet<Detalle_sala> Detalle_sala { get; set; }
        public virtual DbSet<Horario> Horario { get; set; }
        public virtual DbSet<Horario_sala> Horario_sala { get; set; }
        public virtual DbSet<Reserva> Reserva { get; set; }
        public virtual DbSet<Rolex> Rolex { get; set; }
        public virtual DbSet<Sala> Sala { get; set; }
        public virtual DbSet<Usuario_dueno> Usuario_dueno { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
    }
}