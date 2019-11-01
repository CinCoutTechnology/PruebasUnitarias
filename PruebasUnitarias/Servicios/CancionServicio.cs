using PruebasUnitarias.DB;
using PruebasUnitarias.Interface;
using PruebasUnitarias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebasUnitarias.Servicios
{
    public class CancionServicio : ICancionServicio
    {
        LibroContext context;
        public CancionServicio(LibroContext context)
        {
            this.context = context;
        }
        public List<Cancion> GetAllByFilter(string search) 
        {
            var canciones = context.Canciones.AsQueryable();

            if (!string.IsNullOrEmpty(search))
                canciones = context.Canciones.Where(a => a.Nombre == search);

            return canciones.ToList();
        }
    }
}