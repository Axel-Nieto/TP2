using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    class Partida
    {
        private Jugador iJugador;
        private DateTime iInicioPartida;
        private DateTime iFinPartida;
        private double iDuracion;
        private String iPalabra;
        private bool iVictoria;

        public Partida(Jugador pJugador)
        {
            this.iJugador = pJugador;
            this.iVictoria = false;
        }

        public DateTime InicioPartida
        {
            get { return this.iInicioPartida; }
            set { this.iInicioPartida = DateTime.Now; }
        }

        public DateTime FinPartida {
            get { return this.iFinPartida; }
            set { this.iFinPartida = DateTime.Now; }
        }

        public double Duracion
        {
            get { return this.iDuracion; }
            set { this.iDuracion = FinPartida.Subtract(this.iInicioPartida).TotalSeconds; }
        }
        
        public string Palabra
        {
            get { return this.iPalabra; }
            set { this.iPalabra = value;}
        }

        public bool Victoria
        {
            get { return this.iVictoria; }
            set { this.iVictoria = value; }
        }

        public String SeleccionarPalabra(String[] pPalabras)
        {
            Random random = new Random();
            int posicion = random.Next(0, pPalabras.Length);
            return pPalabras[posicion];
        }

        public String ElegirNombre(String nombre)
        {
            return iJugador.Nombre=nombre;
        }

        public String ObtenerNombre()
        {
            return iJugador.Nombre;
        }

        public bool PedirLetra(String pPalabra, String pLetra)
        {
            bool b = false;
            for (int i=0; i < pPalabra.Length;i++)
            {
                if (Convert.ToString(pPalabra[i]).Equals(pLetra))
                {
                    b = true;
                    break;
                }
            }
            return b;
        }
    }
}
