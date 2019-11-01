using PruebasUnitarias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PruebasUnitarias.Interface
{
    public interface IServiceValidation
    {
        void Validation(Libro libro, ModelStateDictionary modelState);
        bool IsValid();
       
    }
}
