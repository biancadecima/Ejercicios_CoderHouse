using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Interfaces
{
    public abstract class Jugador
    {
        private int velocidad;
        private int tiro;
        private int regate;
        private int defensa;
        private int pase;
        private int fisico;

        protected int Velocidad { get => velocidad; set => velocidad = value; }
        protected int Tiro { get => tiro; set => tiro = value; }
        protected int Regate { get => regate; set => regate = value; }
        protected int Defensa { get => defensa; set => defensa = value; }
        protected int Pase { get => pase; set => pase = value; }
        protected int Fisico { get => fisico; set => fisico = value; }

        public Jugador(int velocidad, int tiro, int regate, int defensa, int pase, int fisico)
        { 
            this.Velocidad = velocidad;
            this.Tiro = tiro;
            this.Regate = regate;
            this.Defensa = defensa;
            this.Pase = pase;
            this.Fisico = fisico;
        }
    }
}
