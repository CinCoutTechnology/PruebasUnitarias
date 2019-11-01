using PruebasUnitarias.Interface;
using PruebasUnitarias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebasUnitarias.Controllers
{
    public class LibroController : Controller
    {
        IServiceLibro serviceLibro;
        IServiceValidation serviceValidation;
        public LibroController(IServiceLibro serviceLibro, IServiceValidation serviceValidation)
        {
            this.serviceLibro = serviceLibro;
            this.serviceValidation = serviceValidation;
        }
        // GET: Libro
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Guardar()
        {
            return View("Guardar",new Libro());
        }
        [HttpPost]
        public ActionResult Guardar(Libro libro)
        {
            serviceValidation.Validation(libro, ModelState);
            if (!ModelState.IsValid)
                return View("Guardar", libro);

            serviceLibro.AddLibro(libro);
            return RedirectToAction("Index");
        }
    }
}