using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema04
{
    internal class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            double sumaTotal = 0;
            int contadorNotasValidas = 0;

            if (nota1 != null && nota1.Value >= 0 && nota1.Value <= 10)
            {
                sumaTotal += nota1.Value;
                contadorNotasValidas++;
            }

            if (nota2 != null && nota2.Value >= 0 && nota2.Value <= 10)
            {
                sumaTotal += nota2.Value;
                contadorNotasValidas++;
            }

            if (nota3 != null && nota3.Value >= 0 && nota3.Value <= 10)
            {
                sumaTotal += nota3.Value;
                contadorNotasValidas++;
            }

            // condicion del problema: si las tres son null o invalidas debe retornar 0
            if (contadorNotasValidas == 0)
            {
                return 0; //para que no lance excepcion de divzero
            }

            return sumaTotal / contadorNotasValidas;
        }
    }
}
