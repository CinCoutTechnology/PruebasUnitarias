using Moq;
using NUnit.Framework;
using PruebasUnitarias.DB;
using PruebasUnitarias.Models;
using PruebasUnitarias.Servicios;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Servicios
{
    [TestFixture]
    public class CancionServiceTest
    {
        [Test]
        public void GetByFilterDebeRetornarTodosLosElementonCuandoSerahEsNull()
        {
            

            var data = new List<Cancion>
            {
                 new Cancion {Id = 1,Nombre="bbbb", FechaPublicacion = new DateTime(2019,2,2)},
                 new Cancion {Id = 2,Nombre="bbbb", FechaPublicacion = new DateTime(2019,2,2)},
                 new Cancion {Id = 3,Nombre="bbbb", FechaPublicacion = new DateTime(2019,2,2)}
            }.AsQueryable();

            var dbset = new Mock<DbSet<Cancion>>();
            dbset.As<IQueryable<Cancion>>().Setup(m => m.Provider).Returns(data.Provider);
            dbset.As<IQueryable<Cancion>>().Setup(m => m.Expression).Returns(data.Expression);
            dbset.As<IQueryable<Cancion>>().Setup(m => m.ElementType).Returns(data.ElementType);
            dbset.As<IQueryable<Cancion>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());


            var context = new Mock<LibroContext>();
            context.Setup(o => o.Canciones).Returns(dbset.Object);

            var service = new CancionServicio(context.Object);

            var canciones = service.GetAllByFilter(null);

            Assert.AreEqual(3, canciones.Count());
        }
        [Test]
        public void GetByFilterDebeRetornarUnlementonCuandoSerahwhawha()
        {
            var data = new List<Cancion>
            {
                 new Cancion {Id = 1,Nombre="waka waka", FechaPublicacion = new DateTime(2019,2,2)},
                 new Cancion {Id = 1,Nombre="bbbb", FechaPublicacion = new DateTime(2019,2,2)},
                 new Cancion {Id = 1,Nombre="bbbb", FechaPublicacion = new DateTime(2019,2,2)}
            }.AsQueryable();

            var dbset = new Mock<DbSet<Cancion>>();
            dbset.As<IQueryable<Cancion>>().Setup(m => m.Provider).Returns(data.Provider);
            dbset.As<IQueryable<Cancion>>().Setup(m => m.Expression).Returns(data.Expression);
            dbset.As<IQueryable<Cancion>>().Setup(m => m.ElementType).Returns(data.ElementType);
            dbset.As<IQueryable<Cancion>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());


            var context = new Mock<LibroContext>();
            context.Setup(o => o.Canciones).Returns(dbset.Object);

            var service = new CancionServicio(context.Object);
            var canciones = service.GetAllByFilter("waka waka");

            Assert.AreEqual(1, canciones.Count());
        }
    }
}
