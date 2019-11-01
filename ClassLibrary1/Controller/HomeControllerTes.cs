using NUnit.Framework;
using PruebasUnitarias.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ClassLibrary1.Controller
{
    [TestFixture]
    class HomeControllerTes
    {
        [Test]
        public void IndexDebeRetornarVista()
        {
            var controller = new HomeController();
            var view = controller.Index();

            Assert.IsInstanceOf<ActionResult>(view);
        }
        [Test]
        public void AboutDebeRetornarVista()
        {
            var controller = new HomeController();

            var view = controller.About();

            Assert.IsInstanceOf<ViewResult>(view);
        }
        [Test]
        public void AboutDebeEnviarViewBagAlaVista()
        {
            var controller = new HomeController();

            var view = controller.About() as ViewResult; //Trasformar

            Assert.IsNotNull(view.ViewBag.Message);

        }
    }
}
