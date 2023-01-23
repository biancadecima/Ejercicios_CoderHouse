namespace venta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string fin = "FIN";
            string codigo = String.Empty; ;
            int cantidad;
            int precio = 0;
            string confirmacion;

            while (codigo != fin)
            {
                Console.WriteLine("Ingrese el codigo del producto que desee (DES/JP/DET)");
                codigo = Console.ReadLine();
                if (codigo == "DES")
                {
                    Console.WriteLine("DESODORANTE");
                    Console.WriteLine("Ingrese la cantidad requerida");
                    cantidad = Convert.ToInt32(Console.ReadLine());
                    precio += multiplicar(200, cantidad);
                }
                else if(codigo == "JP")
                {
                    Console.WriteLine("JABON EN POLVO");
                    Console.WriteLine("Ingrese la cantidad requerida");
                    cantidad = Convert.ToInt32(Console.ReadLine());
                    precio += multiplicar(300, cantidad);
                }
                else if(codigo == "DET")
                {
                    Console.WriteLine("DETERGENTE");
                    Console.WriteLine("Ingrese la cantidad requerida");
                    cantidad = Convert.ToInt32(Console.ReadLine());
                    precio += multiplicar(250, cantidad);
                }
                else
                {
                    Console.WriteLine("Codigo inexistente, reintente...");
                }
            }
            if (codigo == fin)
            {
                Console.WriteLine("El monto total es de: " + precio);
                Console.WriteLine("Desea confirmar la compra?");
                confirmacion = Console.ReadLine();
                if(confirmacion == "si")
                {
                    Console.WriteLine("Gracias por comprar en nuestra tienda");
                }
                else
                {
                    Console.WriteLine("Finalizacion del programa...");
                }

            }
            
            int multiplicar(int a, int b)
            {
                return a * b;
            }

        }

    }
}