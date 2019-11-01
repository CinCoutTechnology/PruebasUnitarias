using NUnit.Framework;
using PruebasUnitarias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Model
{
    [TestFixture]
    public class CanncionTest
    {
        [Test]
        public void TestClass()
        {
            var cancion = new Cancion
            {
                Id = 1,
                Nombre = "Cancion 1",
               FechaPublicacion = new DateTime(2019, 02, 18),
            };
            Assert.AreEqual(1,cancion.Id);
            Assert.NotNull("Cancion 1", cancion.Nombre);
            Assert.NotNull(cancion.FechaPublicacion);
        }
    }
}
