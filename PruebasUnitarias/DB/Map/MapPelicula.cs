using PruebasUnitarias.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace PruebasUnitarias.DB.Map
{
    public class MapPelicula : EntityTypeConfiguration<Pelicula>
    {
        public MapPelicula()
        {
            ToTable("Pelicula");
            HasKey(a => a.Id);
        }
    }
}