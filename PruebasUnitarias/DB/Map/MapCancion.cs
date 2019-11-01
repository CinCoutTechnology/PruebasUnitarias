using PruebasUnitarias.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace PruebasUnitarias.DB.Map
{
    public class MapCancion : EntityTypeConfiguration<Cancion>
    {
        public MapCancion()
        {
            ToTable("Cancion");
            HasKey(c => c.Id);
        }
    }
}