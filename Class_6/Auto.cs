using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_6
{
    public class Auto : Vehiculo, IVehiculo
    {
        public Auto(int numeroSerie, double kilometraje, string marca) : base(numeroSerie, kilometraje, marca)
        {
        }

        public void Apagar()
        {
            Console.WriteLine("Apagando auto...");
        }

        public void Arrancar()
        {
            Console.WriteLine("Arrancando auto...");
        }

        public void Frenar()
        {
            Console.WriteLine("Frenando auto...");
        }
    }
}
