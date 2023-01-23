using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Producto
    {
        // atributos de la clase Producto
        private int codigo;
        private string descripcion;
        private double precioDeCompra;
        private double precioDeVenta;
        private string categoria;

        public Producto() // constructor por defecto
        {
            codigo = 0;
            descripcion= string.Empty;
            precioDeCompra = 0;
            precioDeVenta = 0;
            categoria = string.Empty;
        }

        public Producto(int codigo, string descripcion, double precioDeCompra, double precioDeventa, string categoria)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.precioDeCompra = precioDeCompra;
            this.precioDeVenta = precioDeventa;
            this.categoria = categoria;
        }

        public int Codigo
        {
            get
            {
                return this.codigo;
            }
            set
            {
                this.codigo = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }   
            set
            {
                this.descripcion = value;
            }
        }

        public double PrecioDeCompra
        {
            get
            {   
                return this.precioDeCompra;
            }
            set
            {
                this.precioDeCompra = value;
            }
        }

        public double PrecioDeVenta
        {
            get
            {
                return this.precioDeVenta;
            }
            set
            {
                this.precioDeVenta = value;
            }
        }

        public string Categoria
        {
            get
            {
                if (string.IsNullOrEmpty(this.categoria))
                {
                    return "Sin Categoria";
                }
                else
                {
                    return this.categoria;
                }
                
            }
            set
            {
                this.categoria = value;
            }
        }

        public bool verificarPrecioventa()
        {
            return this.precioDeCompra > 0;
        }
    }
}
