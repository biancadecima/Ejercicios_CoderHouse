namespace Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto nuevoProducto = new Producto(017, "jabon", 3.45f, 4.5f, "Limpieza"); // contructor parametrizado
            Producto unProducto = new Producto();// constructor por defecto

            if (nuevoProducto.verificarPrecioventa())
            {
                Console.WriteLine("El producto tiene precio de venta");
            }
            else
            {
                Console.WriteLine("El producto no está publicado");
            }

            if (unProducto.verificarPrecioventa())
            {
                Console.WriteLine("El producto tiene precio de venta");
            }
            else
            {
                Console.WriteLine("El producto no está publicado");
            }
        }
    }
}