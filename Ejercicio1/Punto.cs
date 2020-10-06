using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    public class Punto
    {
        private double iX;
        private double iY;

        /// <summary>
        /// Crea un punto coordenadas (0,0)
        /// </summary>
        public Punto() : this(0, 0) { }

        /// <summary>
        /// Crea un punto a partir de dos coordenadas
        /// </summary>
        /// <param name="pX">Coordenada X</param>
        /// <param name="pY">Coordenada Y</param>
        public Punto(double pX, double pY)
        {
            this.iX = pX;
            this.iY = pY;
        }

        /// <summary>
        /// Solicita la coordenada X de un punto
        /// </summary>
        public double X
        {
            get { return this.iX; }
        }

        /// <summary>
        /// Solicita la coordenada Y de un punto
        /// </summary>
        public double Y
        {
            get { return this.iY; }
        }

        /// <summary>
        /// Calcula la distancia entre dos puntos
        /// </summary>
        /// <param name="pPunto">
        /// Punto 'destino' para calcular la distancia
        /// </param>
        /// <returns>
        /// Regresa un 'double' con dos decimales
        /// </returns>
        public double CalcularDistanciaDesde(Punto pPunto)
        {
            double resultado = Math.Sqrt(Math.Pow(pPunto.X - iX, 2) + Math.Pow(pPunto.Y - iY, 2));
            return Math.Round(resultado, 2);
        }
    }
}
