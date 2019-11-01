using PruebasUnitarias.DB;
using PruebasUnitarias.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebasUnitarias.Controllers
{
    public class CancionController : Controller
    {
        /// <summary>
        /// Tienen un constructor invisible cuando no tiene ningun constructor 
        /// si declaro un cosntructor el constructor invesible ya no existe
        /// </summary>
        /// <returns></returns>
        private ICancionServicio cancionServicio;
        public CancionController(ICancionServicio cancionServicio)
        {
            this.cancionServicio = cancionServicio;
            //this hace referencia a la clase
        }
        [HttpGet]
        // GET: Cancion
        public ActionResult Index(string search)
        {
            var caniones = cancionServicio.GetAllByFilter(search);

            return View(caniones);
        }

    }
}