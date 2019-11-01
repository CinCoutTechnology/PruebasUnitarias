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
using System.Web;
using System.Web.Mvc;

namespace ClassLibrary1.Controller
{
    [TestFixture]
    public class LibroController2
    {
        [Test]
        public void LibroTest()
        {
            var libro = new Libro
            {
                Nombre = "El baile de los que sobra",
                Autor = "",
                FechaPublicaion = new DateTime(2000, 10, 20)

            };
            var modelState = new ModelStateDictionary();

            ///VALIDACION
            var serviceMockValidation = new Mock<IServiceValidation>();
            serviceMockValidation.Setup(o => o.Validation(libro, modelState));
            //serviceMockValidation.Setup(o => o.IsValid()).Returns(false);

            ///GUARADAR
            var serviceMock = new Mock<IServiceLibro>();
            serviceMock.Setup(o => o.AddLibro(libro));

            var controller = new LibroController(serviceMock.Object, serviceMockValidation.Object);
            var view = controller.Guardar(libro) as RedirectToRouteResult;

            Assert.IsInstanceOf<RedirectToRouteResult>(view);

        }
        [Test]
        public void LibroTestIsValid()
        {

        }
        ///PARA PODER MOCK EL SESSION
        public ControllerContext FakeHttContext()
        {
            var cContext = new Mock<ControllerContext>();
            var context = new Mock<HttpContextBase>();
            var request = new Mock<HttpRequestBase>();
            var response = new Mock<HttpResponseBase>();
            var session = new MockHttpSession();
            var server = new Mock<HttpServerUtilityBase>();

            context.Setup(ctx => ctx.Request).Returns(request.Object);
            context.Setup(ctx => ctx.Response).Returns(response.Object);
            context.Setup(ctx => ctx.Session).Returns(session);
            context.Setup(ctx => ctx.Server).Returns(server.Object);

            cContext.Setup(o => o.HttpContext).Returns(context.Object);
            return cContext.Object;

        }
        public class MockHttpSession : HttpSessionStateBase
        {
            Dictionary<String, object> m_SessionStorage = new Dictionary<string, object>();

            public override object this[string name]
            {
                get { return m_SessionStorage[name]; }
                set { m_SessionStorage[name] = value; }
            }
        }
        //[Test]
        //public void LibroTestNoPasa()
        //{
        //    var libro = new Libro();
        //    var modelState = new ModelStateDictionary();
        //    ///VALIDACION
        //    var serviceMockValidation = new Mock<IServiceValidation>();
        //    serviceMockValidation.Setup(o => o.Validation(libro, modelState));
        //    serviceMockValidation.Setup(o => o.IsValid()).Returns(false);

        //    ///GUARADAR
        //    var serviceMock = new Mock<IServiceLibro>();
        //    serviceMock.Setup(o => o.AddLibro(libro));

        //    var controller = new LibroController(serviceMock.Object, serviceMockValidation.Object);
        //    var view = controller.Guardar(libro) as RedirectToRouteResult;

        //    Assert.IsNotInstanceOf<RedirectToRouteResult>(view);
        //    //tiene éxito si el objeto proporcionado como valor real no es una instancia del tipo esperado.
        //}
    }

    
}
// var serviceMock = new Mock<Interface>();
/*
 * tcMock.Setup(o => o.Get()).Returns(3);
 serviceMock
 var controller = new PersonaController(serviceMock.Objeto)
*/
/*
   mockValidation.Verify(o => o.Validate(usuario, modelState), Times.AtLeastOnce);
   mockValidation.Verify(o => o.IsValid(), Times.AtLeastOnce);
   mockService.Verify(o => o.agregarAdministrador(usuario), Times.AtMostOnce);
*/
/*
  var mock = new Mock<IAdministradorService>();
       mock.Setup(o => o.retornarListaAdministradores());

       var controller = new AdminController(mock.Object, null);
       var result = controller.Index() as ViewResult;

       Assert.IsInstanceOf<ViewResult>(result);
       mock.Verify(o => o.retornarListaAdministradores(), Times.AtMostOnce); 
*/
