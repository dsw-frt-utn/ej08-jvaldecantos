using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema06
{
    internal static class Extensions
    {
        public static string ToProductCode(this string code)
        {
            if (code == null)
            {
                return "SIN-CODIGO";
            }
            
            code = code.Trim(); // elimina espacios de los costados
            code = code.ToUpper(); // pasa a mayus
            code = code.Replace(" ", "-"); // reemplaza espacios internos por guiones

            return code;
        }
    }
}
