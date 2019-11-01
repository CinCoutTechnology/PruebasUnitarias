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
    public class PeliculaServiceTest
    {
        [Test]
        public void GetByFilterDebeRetornarTodosLosElementonCuandoSerahEsNull()
        {
            var data = new List<Pelicula>
            {
                 new Pelicula {Id = 1,Nombre="Locos",Director = "Anderson", Fecha = new DateTime(2019,2,2)},
                 new Pelicula {Id = 2,Nombre="Alfa",Director = "Coral", Fecha = new DateTime(2019,2,2)},
                 new Pelicula {Id = 3,Nombre="Omega",Director = "Zamora", Fecha = new DateTime(2019,2,2)},
                 new Pelicula {Id = 4,Nombre="Alfa",Director = "Beto", Fecha = new DateTime(2019,2,2)},
            }.AsQueryable();

            var dbset = new Mock<DbSet<Pelicula>>();
            dbset.As<IQueryable<Pelicula>>().Setup(m => m.Provider).Returns(data.Provider);
            dbset.As<IQueryable<Pelicula>>().Setup(m => m.Expression).Returns(data.Expression);
            dbset.As<IQueryable<Pelicula>>().Setup(m => m.ElementType).Returns(data.ElementType);
            dbset.As<IQueryable<Pelicula>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var context = new Mock<LibroContext>();
            context.Setup(p => p.Peliculas).Returns(dbset.Object);


            var service = new PeliculaServicio(context.Object);

            var peliculas = service.GetAllByFilteret(null,null);
            Assert.AreEqual(4, peliculas.Count());
        }
        [Test]
        public void GetByFilterDebeRetornarTodosLosElementonCuandoSerahBusqueda()
        {
            var data = new List<Pelicula>
            {
                 new Pelicula {Id = 1,Nombre="Locos",Director = "Anderson", Fecha = new DateTime(2019,2,2)},
                 new Pelicula {Id = 2,Nombre="Alfa",Director = "Coral", Fecha = new DateTime(2019,2,2)},
                 new Pelicula {Id = 3,Nombre="Omega",Director = "Zamora", Fecha = new DateTime(2019,2,2)},
                 new Pelicula {Id = 4,Nombre="Alfa",Director = "Beto", Fecha = new DateTime(2019,2,2)},
            }.AsQueryable();

            var dbset = new Mock<DbSet<Pelicula>>();
            dbset.As<IQueryable<Pelicula>>().Setup(m => m.Provider).Returns(data.Provider);
            dbset.As<IQueryable<Pelicula>>().Setup(m => m.Expression).Returns(data.Expression);
            dbset.As<IQueryable<Pelicula>>().Setup(m => m.ElementType).Returns(data.ElementType);
            dbset.As<IQueryable<Pelicula>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var context = new Mock<LibroContext>();
            context.Setup(p => p.Peliculas).Returns(dbset.Object);

            var service = new PeliculaServicio(context.Object);

            var peliculas = service.GetAllByFilteret("Locos", "Anderson");
            Assert.AreEqual(1, peliculas.Count());
        }
    }
}
