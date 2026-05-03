namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanciamos nuestra clase helper
            ProductHelper helper = new ProductHelper();

            // Llamamos al método con datos de prueba
            string etiqueta = helper.ObtenerEtiquetaProducto(1029384756, "Teclado Mecánico Inalámbrico", 45500.50m);

            // Imprimimos el resultado en consola
            Console.WriteLine(etiqueta);
        }
    }
}
