using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_6
{
    public abstract class Vehiculo
    {
        public int numeroSerie;
        public double kilometraje;
        public string marca;

        public Vehiculo(int numeroSerie, double kilometraje, string marca)
        {
            this.numeroSerie = numeroSerie;
            this.kilometraje = kilometraje;
            this.marca = marca;
        }

        public override string ToString()
        {
            return "Nro de serie: " + this.numeroSerie + "\nKilometraje: " + this.kilometraje + "\nMarca: " + this.marca;
        }
    }
}
