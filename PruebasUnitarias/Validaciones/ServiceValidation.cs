using PruebasUnitarias.Interface;
using PruebasUnitarias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebasUnitarias.Validaciones
{
    public class ServiceValidation : IServiceValidation
    {
        private ModelStateDictionary modelState;
        public void Validation(Libro libro, ModelStateDictionary modelState)
        {
            DateTime FechaPublicaion = libro.FechaPublicaion;
            int fecha = DateTime.Today.AddTicks(-FechaPublicaion.Ticks).Year - 1;

            if (fecha > 119)
                modelState.AddModelError("FechaPublicaion", "Invalido");
               
            if(String.IsNullOrEmpty(libro.Nombre))
                modelState.AddModelError("Nombre", "Requerido");

            if (String.IsNullOrEmpty(libro.Autor))
                modelState.AddModelError("Autor", "Requerido");

        }
        public bool IsValid()
        {
            return modelState.IsValid;
        }
    }
}