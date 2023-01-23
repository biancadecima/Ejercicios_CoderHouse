using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_8
{
    class ProductoConE
    {
        private List<Producto> productosConE;

        public ProductoConE()
        {
            productosConE = new List<Producto>();
        }

        public void InsertarEnLista(Producto[] arrayProductos)
        {
            for(int i = 0; i< arrayProductos.Length; i++)
            {
                if (arrayProductos[i].descripcion.Contains("E") || arrayProductos[i].descripcion.Contains("e"))
                {
                    productosConE.Add(arrayProductos[i]);
                }
            }
        }

        public bool MostrarLista()
        {
            if (productosConE.Count == 0)
            {
                return false;
            }
            else
            {
                Console.WriteLine("Productos con E:");
                foreach (Producto producto in productosConE)
                {
                    Console.WriteLine($"Codigo: {producto.codigo} - Descripcion: {producto.descripcion}");
                }
                return true;
            }
        }

        public void LimpiarLista()
        {
            productosConE.Clear();
            Console.WriteLine("Lista limpiada");
        }
    }
}
