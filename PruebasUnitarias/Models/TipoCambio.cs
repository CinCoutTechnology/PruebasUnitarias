using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebasUnitarias.Models
{
    public class TipoCambio
    {
        public TipoCambioResult result { get; set; }
    }
    public class TipoCambioResult
    {
        public decimal value { get; set; }
    }
}