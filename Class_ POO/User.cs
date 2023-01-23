using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class__POO
{
    internal class User
    {
        private string nombre;
        private string dni;
        private string mail;
        private short edad;
        private string domicilio;
        private string usuarioSys;
        private string passwordSys;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Mail { get => mail; set => mail = value; }
        public short Edad { get => edad; set => edad = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }

        public string UsuarioSys // setter y getter manual
        {
            get
            {
                return usuarioSys;
            }

            set
            {
                usuarioSys = value;
            }
        }

        public string PasswordSys // setter y getter manual
        {
            get
            {
                return passwordSys;
            }

            set
            {
                if (value.Length > 6)
                {
                    passwordSys = value;
                }
                else
                {
                    passwordSys = null;
                }
                
            }
        }
    }
}
