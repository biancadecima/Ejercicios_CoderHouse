using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class__POO
{
    internal class Persona : User
    {
        private int id;
        private string dni;
        private string name;

        public Persona()
        {
            id = 0;
            dni = "No asignado";
            name = "No asignado";
        }

        public Persona(int id, string dni, string name)
        {
            this.id = id;
            this.dni = dni;
            this.name = name;
        }

        public Persona(string dni, string name)
        {
            this.dni = dni;
            this.name = name;
            Random rd = new Random();// Para generar un número random
            id = rd.Next(0, 1000) ;
        }
    }
}
