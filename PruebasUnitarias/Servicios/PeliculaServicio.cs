using PruebasUnitarias.DB;
using PruebasUnitarias.Interface;
using PruebasUnitarias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebasUnitarias.Servicios
{
    public class PeliculaServicio : IPeliculaServicio
    {
        LibroContext context;
        public PeliculaServicio(LibroContext context)
        {
            this.context = context;

        }
        public List<Pelicula> GetAllByFilteret(string search, string search2)
        {
            var peliculas = context.Peliculas.AsQueryable();

            if (!string.IsNullOrEmpty(search))
                peliculas = context.Peliculas.Where(a => a.Nombre == search && a.Director == search2);

           return peliculas.ToList();
        }
    }
}