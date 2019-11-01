using PruebasUnitarias.Consumidores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PruebasUnitarias.Controllers
{
    public class CambioController : Controller
    {
        private ItipoDeCambioConsumidor tc;
        public CambioController(ItipoDeCambioConsumidor tc)
        {
            this.tc = tc;
        }
        // GET: Cambio
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(int TipoCambio, decimal Monto)
        {
            ViewBag.Monto = Monto * tc.Get();

            return View();

        }
    }
}