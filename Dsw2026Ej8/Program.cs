using Dsw2026Ej8.Problema01;
using Dsw2026Ej8.Problema02;
using Dsw2026Ej8.Problema03;
using Dsw2026Ej8.Problema04;
using Dsw2026Ej8.Problema05;
using Dsw2026Ej8.Problema06;

namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("=== TP8 DSW 2026 - VALDECANTOS JOAQUIN / 60326 / 3K3 ===");
                Console.WriteLine("1. Problema 1 (Clase Parcial)");
                Console.WriteLine("2. Problema 2 (Clase Anónima)");
                Console.WriteLine("3. Problema 3 (Valor vs Referencia)");
                Console.WriteLine("4. Problema 4 (Notas Nulables)");
                Console.WriteLine("5. Problema 5 (Herencia - Ventas)");
                Console.WriteLine("6. Problema 6 (Métodos de Extensión)");
                Console.WriteLine("0. Salir");
                Console.Write("\nSeleccione una opción: ");
                
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "0":
                        {
                            continuar = false;
                            Console.WriteLine("Saliendo del programa");
                            continue;
                        }
                    
                    case "1":
                        {
                            Console.WriteLine("\nEjecutando Problema 1:");
                            //instanciamos 
                            ProductHelper p = new ProductHelper();

                            //llamamos el metodo para probar
                            string etiqueta = p.ObtenerEtiquetaProducto(11223, "Jersey", 49500.50m);
                            Console.WriteLine(etiqueta);

                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("\nEjecutando Problema 2:");

                            Problema2 ej2 = new Problema2();
                            string resultado = ej2.CrearResumenVenta(1406, "Chocolate", 2, 1499.99m);
                            Console.WriteLine(resultado);

                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("\nEjecutando Problema 3:");

                            Product p3 = new Product { Description = "Original" };
                            Problema3 ej3 = new Problema3();

                            string resultado = ej3.CompararCopias(10, p3);
                            Console.WriteLine(resultado);

                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("\nEjecutando Problema 4:");
                            var ej4 = new Problema4();

                            // una null, un 7, y una invalida
                            // promedio: 7 / 1 = 7
                            double res1 = ej4.CalcularPromedio(7, null, 15);
                            Console.WriteLine($"Notas [7, null, 15] -> Resultado: {res1}");

                            // todo null
                            double res2 = ej4.CalcularPromedio(null, null, null);
                            Console.WriteLine($"Notas [null, null, null] -> Resultado: {res2}");
                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine("\nEjecutando Problema 5:");
                            var ej5 = new Problema5();

                            // venta minorista por 1000
                            Sale ventaMin = new RetailSale { Monto = 1000 };
                            // venta mayorista por 1000
                            Sale ventaMay = new WholesaleSale { Monto = 1000 };

                            decimal totalMin = ej5.ObtenerImporteFinal(ventaMin);
                            decimal totalMay = ej5.ObtenerImporteFinal(ventaMay);

                            Console.WriteLine($"Venta Retail (Monto): ${totalMin:N2}");
                            Console.WriteLine($"Venta Wholesale (Monto - 10%): ${totalMay:N2}");
                            break;
                        }
                    case "6":
                        {
                            Console.WriteLine("\nEjecutando Problema 6:");
                            var ej6 = new Problema6();

                            string codigoSucio = "  ab 123 x  ";
                            string resultado = ej6.NormalizarCodigoProducto(codigoSucio);

                            Console.WriteLine($"Entrada: '{codigoSucio}'");
                            Console.WriteLine($"Salida:  '{resultado}'"); // salida: 'AB-123-X'

                            // prueba del null
                            Console.WriteLine($"Prueba null: {ej6.NormalizarCodigoProducto(null)}");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Opción no válida.");
                            break;
                        }
                }
                
                Console.WriteLine("\nPresione cualquier tecla para volver al menu...");
                Console.ReadKey();
            }
        }
    }
}
