namespace Class_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto[] productos ={ new Producto(1 ,"Yogur Descremado"),
                                    new Producto(2,"Leche"),
                                    new Producto(3,"Huevos"),
                                    new Producto(4,"Vino"),
                                    new Producto(5,"Sal"),
                                    new Producto(6,"Estufa")
            };

            ProductoConE productoConE = new ProductoConE(); // Las listas son dinamicas, los arrays tienen dimesion fija
            
            productoConE.InsertarEnLista(productos);
            productoConE.MostrarLista();
            productoConE.LimpiarLista();
        }
    }
}