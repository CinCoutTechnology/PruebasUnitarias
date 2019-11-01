using PruebasUnitarias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasUnitarias.Interface
{
    public interface ICancionServicio
    {
        List<Cancion> GetAllByFilter(string search);
    }
}
