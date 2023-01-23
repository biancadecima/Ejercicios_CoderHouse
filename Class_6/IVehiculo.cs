using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_6
{
    internal interface IVehiculo
    {
        public void Arrancar(); // no declaro su cuerpo, solo su firma
        public void Frenar();
        public void Apagar();
    }
}
