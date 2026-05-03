using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema05
{
    internal class RetailSale : Sale
    {
        public override decimal CalcularTotal()
        {
            return Monto;
        }
    }
}
