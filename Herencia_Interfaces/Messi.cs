using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Interfaces
{
    internal class Messi : Jugador, IJugador
    {
        public Messi(int velocidad, int tiro, int regate, int defensa, int pase, int fisico) : base(velocidad, tiro, regate, defensa, pase, fisico)
        {
        }

        public void colocarPase()
        {
            Console.WriteLine("Lionel Messi colocó un Pase con {0} de propiedad", this.Pase);
        }

        public void correr()
        {
            Console.WriteLine("Lionel Messi corrió con {0} de propiedad", this.Velocidad);
        }

        public void defender()
        {
            Console.WriteLine("Lionel Messi  defendió con {0} de propiedad", this.Defensa);
        }

        public void regatear()
        {
            Console.WriteLine("Lionel Messi  regateó con {0} de propiedad", this.Regate);
        }

        public void rematar()
        {
            Console.WriteLine("Lionel Messi  remató con {0} de propiedad", this.Tiro);
        }

        public void soportarEmbate()
        {
            Console.WriteLine("Lionel Messi  soporto el embate del oponente con {0} de propiedad", this.Fisico);
        }
    }
}
