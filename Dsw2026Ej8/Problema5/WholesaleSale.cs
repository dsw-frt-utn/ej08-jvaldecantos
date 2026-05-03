using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema05
{
    internal class WholesaleSale : Sale
    {
        public override decimal CalcularTotal()
        {
            return Monto * 0.9m;
        }
    }
}
