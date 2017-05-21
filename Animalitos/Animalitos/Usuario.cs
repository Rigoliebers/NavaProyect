using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Animalitos
{
    public class Usuario
    {
        private string _nombre;
        private string _password;
        private string _correo;
        private string _nivel;



        public string Correo
        {
            get { return _correo; }
            set { _correo = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Nivel
        {
            get { return _nivel; }
            set { _nivel = value; }
        }
    }
}