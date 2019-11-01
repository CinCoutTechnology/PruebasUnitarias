using Moq;
using NUnit.Framework;
using PruebasUnitarias.Controllers;
using PruebasUnitarias.Interface;
using PruebasUnitarias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ClassLibrary1.Controller
{
    [TestFixture]
    public class PelicualControlTest
    {
        [Test]
        public void IndexDebeRetornarVisataConListaDePeliculas()
        {
            var service = new Mock<IPeliculaServicio>();

            service.Setup(o => o.GetAllByFilteret(null,null)).Returns(new List<Pelicula>());
            var controller = new PeliculaController(service.Object);

            var view = controller.Index(null,null) as ViewResult;

            Assert.IsInstanceOf<ViewResult>(view);
            Assert.IsInstanceOf<List<Pelicula>>(view.Model);

        }
    }
}
