using PruebasUnitarias.DB.Map;
using PruebasUnitarias.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PruebasUnitarias.DB
{
    public class LibroContext : DbContext
    {
        public DbSet<Libro> Libros { get; set; }

        public virtual DbSet<Cancion> Canciones { get; set; }

        public virtual DbSet<Pelicula> Peliculas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new MapLibro());
            modelBuilder.Configurations.Add(new MapCancion());
            modelBuilder.Configurations.Add(new MapPelicula());
        }
    }
}