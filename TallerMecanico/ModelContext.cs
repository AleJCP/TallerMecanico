using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using TallerMecanico.Entidades;

namespace TallerMecanico
{
    partial class ModelContext : DbContext
    {
        //DBSET CONTEXT
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Servicio_Vehiculo> Servicio_Vehiculos { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<User> Users { get; set; }
        public ModelContext()
            : base("name=ModelContext")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
