using PruebasUnitarias.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace PruebasUnitarias.DB.Map
{
    public class MapLibro : EntityTypeConfiguration<Libro>
    {
        public MapLibro()
        {
            ToTable("Libro");
            HasKey(a => a.Id);
        }
    }
}