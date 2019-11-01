using PruebasUnitarias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebasUnitarias.Interface
{
    public interface IPeliculaServicio
    {
        List<Pelicula> GetAllByFilteret(string search,string search2);
    }
}