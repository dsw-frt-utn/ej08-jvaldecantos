using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema03
{
    internal class Problema3
    {
        public string CompararCopias (int originalValue, Product product)
        {
            int copiaVal = originalValue;
            copiaVal++;
            Product copiaProducto = product;
            copiaProducto.ModDescription("NuevaDescripcion");

            return $"{originalValue} - {copiaVal} - {product.Description}";
        }
    }
}
