using PruebasUnitarias.DB;
using PruebasUnitarias.Interface;
using PruebasUnitarias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebasUnitarias.Servicios
{
    public class ServiceLibro : IServiceLibro
    {
        private LibroContext context;

        public ServiceLibro()
        {
            context = new LibroContext();
        }

        public void AddLibro(Libro libro)
        {
            context.Libros.Add(libro);
            context.SaveChanges();
        }
    }
}