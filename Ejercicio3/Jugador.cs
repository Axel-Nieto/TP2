using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    class Jugador
    {
        private String iNombre;

        public Jugador() : this("") { }

        public Jugador(String pNombre)
        {
            this.iNombre = pNombre;
        }

        public String Nombre
        {
            get { return this.iNombre; }
            set { this.iNombre = value; }
        }
    }
}
