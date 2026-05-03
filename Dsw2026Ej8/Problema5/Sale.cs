using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema05
{
    internal class Sale
    {
        public decimal Monto { get; set; }

        public virtual decimal CalcularTotal()
        {
            return Monto;
        }
    }
}
