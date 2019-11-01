using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebasUnitarias.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Director { get; set; }
        public DateTime Fecha { get; set; }   
    }
}