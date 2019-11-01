using Moq;
using NUnit.Framework;
using PruebasUnitarias.Consumidores;
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
    class CambioControllerTest
    {
        [Test]
        public void CambioIndexDebeRetornarView()
        {
            var controller = new CambioController(null);
            var view = controller.Index();

            Assert.IsInstanceOf<ViewResult>(view);
        }
        [Test]
        public void CambioIndexDebeRetoranrPostView()
        {

            var tcMock = new Mock<ItipoDeCambioConsumidor>();
            var controller = new CambioController(tcMock.Object);
            var view = controller.Index(1, 10);
            Assert.IsInstanceOf<ViewResult>(view);
        }
        [Test]
        public void CambioIndexDebeRetoranr10()
        {

            var tcMock = new Mock<ItipoDeCambioConsumidor>();
            tcMock.Setup(m => m.Get()).Returns(3m);

            var controller = new CambioController(tcMock.Object);
            var view = controller.Index(1, 10) as ViewResult;
            Assert.AreEqual(30m, view.ViewBag.Monto);
        }
        [Test]
        public void CambioIndexPostDebeCalcularMonto200()
        {
            var tcMock = new Mock<ItipoDeCambioConsumidor>();
            tcMock.Setup(m => m.Get()).Returns(3.4m);

            var controller = new CambioController(tcMock.Object);
            var view = controller.Index(1, 200) as ViewResult;
            Assert.AreEqual(680m, view.ViewBag.Monto);
        }
    }
}
