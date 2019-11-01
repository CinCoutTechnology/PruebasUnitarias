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
    public class CancionControllerTest
    {
        [Test]
        public void IndexDebeRetornarVisataConListaDeCanciones()
        {
            var service = new Mock<ICancionServicio>();

            service.Setup(o => o.GetAllByFilter(null)).Returns(new List<Cancion>());
            var controller = new CancionController(service.Object);


            var view = controller.Index(null) as ViewResult;
            Assert.IsInstanceOf<ViewResult>(view); 
            Assert.IsInstanceOf<List<Cancion>>(view.Model); //Que el view.model sea una instancia de canciones
        }

    }
}
