using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Dsw2026Ej8.Problema01
{
    partial class ProductHelper
    {
        private string ObtenerFormatoEtiqueta(long code, string description, string price)
        {
            return $"[{code}] {description} - {price}";
        }
    }
}
