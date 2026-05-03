using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema01
{
    partial class ProductHelper
    {
        public string ObtenerEtiquetaProducto(long code, string description, decimal price)
        {
            string precioMoneda = $"${price:N2}";

            return ObtenerFormatoEtiqueta(code, description, precioMoneda);
        }
    }
}
