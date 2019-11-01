using PruebasUnitarias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebasUnitarias.Interface
{
    public interface IServiceLibro
    {
        void AddLibro(Libro libro);
    }
}