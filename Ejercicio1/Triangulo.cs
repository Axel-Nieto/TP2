using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    public class Triangulo
    {
        private Punto iPunto1;
        private Punto iPunto2;
        private Punto iPunto3;

        /// <summary>
        /// Crea un triangulo a partir de tres puntos
        /// </summary>
        /// <param name="pPunto1">Punto 1</param>
        /// <param name="pPunto2">Punto 2</param>
        /// <param name="pPunto3">Punto 3</param>
        public Triangulo(Punto pPunto1, Punto pPunto2, Punto pPunto3)
        {
            this.iPunto1 = pPunto1;
            this.iPunto2 = pPunto2;
            this.iPunto3 = pPunto3;
        }

        /// <summary>
        /// Solicita las coordenadas del punto 1 del triangulo
        /// </summary>
        public Punto Punto1
        {
            get { return this.iPunto1; }
        }

        /// <summary>
        /// Solicita las coordenadas del punto 2 del triangulo
        /// </summary>
        public Punto Punto2
        {
            get { return this.iPunto2; }
        }

        /// <summary>
        /// Solicita las coordenadas del punto 3 del triangulo
        /// </summary>
        public Punto Punto3
        {
            get { return this.iPunto3; }
        }

        /// <summary>
        /// Calcula el area del triangulo
        /// </summary>
        /// <returns>
        /// Devuelve un 'double' con dos decimales
        /// </returns>
        public double Area()
        {
            double ladoA = iPunto1.CalcularDistanciaDesde(iPunto2);
            double ladoB = iPunto2.CalcularDistanciaDesde(iPunto3);
            double ladoC = iPunto3.CalcularDistanciaDesde(iPunto1);
            double semiperimetro = (ladoA + ladoB + ladoC) / 2;
            double area = Math.Sqrt(semiperimetro * (semiperimetro - ladoA) * (semiperimetro - ladoB) * (semiperimetro - ladoC));
            return Math.Round(area, 2);
        }

        /// <summary>
        /// Calcula el perimetro del triangulo
        /// </summary>
        /// <returns>
        /// Devuelve un 'double' con dos decimales
        /// </returns>
        public double Perimetro()
        {
            double ladoA = iPunto1.CalcularDistanciaDesde(iPunto2);
            double ladoB = iPunto2.CalcularDistanciaDesde(iPunto3);
            double ladoC = iPunto3.CalcularDistanciaDesde(iPunto1);
            double perimetro = ladoA + ladoB + ladoC;
            return Math.Round(perimetro, 2);
        }
    }
}
