using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Contexto : DbContext
    {
        public Contexto() : base()
        {

        }
        public DbSet <auntetificación> Autentificación { get; set; }
        public DbSet<Datos_proveedor> Datos_proveedor { get; set; }
        public DbSet<DatosVarios> DatosVarios { get; set; }
        public DbSet<IngresoActa> IngresodelActa { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlSever(ConfigurationManager.ConnectionStrings["Acta_de_recepcion_tecnica"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

            builder.Entity<autentificación>();
            builder.Entity<Datos_proveedor>();
            builder.Entity<DatosVarios>();
            builder.Entity<IngresoActa>();

        }
    }
}

