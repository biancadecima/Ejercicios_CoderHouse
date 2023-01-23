using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_6
{
    internal class Moto : Vehiculo, IVehiculo
    {
        public Moto(int numeroSerie, double kilometraje, string marca) : base(numeroSerie, kilometraje, marca)
        {
        }

        public void Apagar()
        {
            Console.WriteLine("Apagando moto...");
        }

        public void Arrancar()
        {
            Console.WriteLine("Arrancando moto...");
        }

        public void Frenar()
        {
            Console.WriteLine("Frenando moto..."); 
        }
    }
}
