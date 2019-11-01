using PruebasUnitarias.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebasUnitarias.Controllers
{
    public class PeliculaController : Controller
    {
        private IPeliculaServicio servicio;
        public PeliculaController(IPeliculaServicio servicio)
        {
            this.servicio = servicio;
        }
        // GET: Pelicula
        public ActionResult Index(string search, string search2)
        {

            var peliculas = servicio.GetAllByFilteret(search, search2);
            return View(peliculas);
        }
    }
}