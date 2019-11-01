using Newtonsoft.Json;
using PruebasUnitarias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace PruebasUnitarias.Consumidores
{
    public interface ItipoDeCambioConsumidor
    {
        decimal Get();
    }

    public class TipoDeCambioConsumidor : ItipoDeCambioConsumidor
    {
        public decimal Get()
        {
            WebClient client = new WebClient();
            var response = client.DownloadString("https://api.cambio.today/v1/quotes/USD/PEN/json?quantity=1&key=2504|Ms5cdUWksQE3tWDq9p7uOubVCA_2~Osb");

            var tc = JsonConvert.DeserializeObject<TipoCambio>(response);

            return tc.result.value;
        }
    }
}