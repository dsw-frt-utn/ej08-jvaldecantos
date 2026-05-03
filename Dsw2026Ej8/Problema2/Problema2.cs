using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Dsw2026Ej8.Problema02
{
    internal class Problema2
    {
        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            decimal totalCalc = quantity > 0 ? (quantity * unitPrice) : 0;

            var resumen = new
            {
                Code = productCode,
                Description = productDescription,
                Quantity = quantity,
                Total = totalCalc
            };

            return $"{resumen.Code}-{resumen.Description}-{resumen.Total}";
        }
    }
}
