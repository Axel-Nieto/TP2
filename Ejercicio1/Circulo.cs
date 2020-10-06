using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    public class Circulo
    {
        private Punto iCentro = new Punto();
        private double iRadio = 0;

        /// <summary>
        /// Crea un circulo a partir de un punto y un radio
        /// </summary>
        /// <param name="pCentro">Punto del centro de la circunferencia</param>
        /// <param name="pRadio">Radio de la circunferencia</param>
        public Circulo(Punto pCentro, double pRadio)
        {
            this.iCentro = pCentro;
            this.iRadio = pRadio;
        }

        /// <summary>
        /// Crea un circulo a partir de las dos coordenadas del centro, y un radio
        /// </summary>
        /// <param name="pX">Coordenada X</param>
        /// <param name="pY">Coordenada Y</param>
        /// <param name="pRadio">Radio de la circunferencia</param>
        public Circulo(double pX, double pY, double pRadio)
        {
            this.iCentro = new Punto(pX,pY);
            this.iRadio = pRadio;
        }

        /// <summary>
        /// Solicita el punto que representa el centro de la circunferencia
        /// </summary>
        public Punto Centro
        {
            get { return this.iCentro; }
        }

        /// <summary>
        /// Solicita el radio de la circunferencia
        /// </summary>
        public double Radio
        {
            get { return this.iRadio; }
        }

        /// <summary>
        /// Calcula el area del circulo
        /// </summary>
        /// <returns>
        /// Devuelve un 'double' con dos decimales
        /// </returns>
        public double Area()
        {
            double area = Math.PI * Math.Pow(iRadio, 2);
            return Math.Round(area, 2);
        }

        /// <summary>
        /// Calcula el perimetro del circulo
        /// </summary>
        /// <returns>
        /// Devuelve un 'double' con dos decimales
        /// </returns>
        public double Perimetro()
        {
            double perimetro = 2 * Math.PI * iRadio;
            return Math.Round(perimetro, 2);
        }
    }
}
