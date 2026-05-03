namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Problema1 Pruebas
            ////instanciamos 
            //ProductHelper p = new ProductHelper();

            ////llamamos el metodo para probar
            //string etiqueta = p.ObtenerEtiquetaProducto(11223, "Jersey", 49500.50m);
            //Console.WriteLine(etiqueta);

            Problema2 ej2 = new Problema2();
            string resultado = ej2.CrearResumenVenta(1406, "Chocolate", 2, 1499.75m);
            Console.WriteLine(resultado);
        }
    }
}
