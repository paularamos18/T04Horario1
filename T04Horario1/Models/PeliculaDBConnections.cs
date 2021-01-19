using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace T04Horario1.Models
{
    public class PeliculaDBConnections:DbContext
    {
        public PeliculaDBConnections() : base("PeliculaBd")
        {

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public DbSet<Pelicula> Peliculas { get; set; }
    }

}