using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    public class UI
    {
        private int iOpcion1;
        private int iOpcion2;

        /// <summary>
        /// Devuelve/Asigna el valor de la opcion del menu
        /// </summary>
        public int Opcion1
        {
            get { return this.iOpcion1; }
            set { this.iOpcion1 = value; }
        }

        /// <summary>
        /// Devuelve/Asigna el valor de la opcion del menu
        /// </summary>
        public int Opcion2
        {
            get { return this.iOpcion2; }
            set { this.iOpcion2 = value; }
        }

        /// <summary>
        /// Imprime en pantalla el menu principal
        /// </summary>
        /// <returns>
        /// Regresa el numero de opcion ingresado
        /// </returns>
        public int MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("PROGRAMA  DEL  TP1:  EJERCICIO  1");
            Console.WriteLine("");
            Console.WriteLine("MENU PRINCIPAL");
            Console.WriteLine("");
            Console.WriteLine("Seleccione una opcion");
            Console.WriteLine("1.Dos puntos");
            Console.WriteLine("2.Circulo");
            Console.WriteLine("3.Triangulo");
            Console.WriteLine("");
            Console.WriteLine("0.Salir");
            this.Opcion1 = Convert.ToInt32(Console.ReadLine());
            return this.Opcion1;
        }

        /// <summary>
        /// Imprime en pantalla el menu para operar con puntos
        /// </summary>
        /// <returns>
        /// Regresa el numero de opcion ingresado
        /// </returns>
        public int MenuSecundarioPuntos()
        {
            Console.Clear();
            Console.WriteLine("PROGRAMA  DEL  TP1:  EJERCICIO  1");
            Console.WriteLine("");
            Console.WriteLine("Seleccione una opcion:");
            Console.WriteLine("");
            Console.WriteLine("1.Definir puntos");
            Console.WriteLine("2.Calcular distancia entre dos puntos");
            Console.WriteLine("");
            Console.WriteLine("0.Volver");
            this.Opcion2 = Convert.ToInt32(Console.ReadLine());
            return this.Opcion2;
        }

        /// <summary>
        /// Imprime en pantalla el menu para operar con circulos
        /// </summary>
        /// <returns>
        /// Regresa el numero de opcion ingresado
        /// </returns>
        public int MenuSecundarioCirculo()
        {
            Console.Clear();
            Console.WriteLine("PROGRAMA  DEL  TP1:  EJERCICIO  1");
            Console.WriteLine("");
            Console.WriteLine("Seleccione una opcion:");
            Console.WriteLine("");
            Console.WriteLine("1.Definir circulo");
            Console.WriteLine("2.Calcular area del circulo");
            Console.WriteLine("3.Calcular perimetro del circulo");
            Console.WriteLine("4.Calcular area y perimetro del circulo");
            Console.WriteLine("");
            Console.WriteLine("0.Volver");
            this.Opcion2 = Convert.ToInt32(Console.ReadLine());
            return this.Opcion2;
        }

        /// <summary>
        /// Imprime en pantalla el menu para operar con triangulos
        /// </summary>
        /// <returns>
        /// Regresa el numero de opcion ingresado
        /// </returns>
        public int MenuSecundarioTriangulo()
        {
            Console.Clear();
            Console.WriteLine("PROGRAMA  DEL  TP1:  EJERCICIO  1");
            Console.WriteLine("");
            Console.WriteLine("Seleccione una opcion:");
            Console.WriteLine("");
            Console.WriteLine("1.Definir triangulo");
            Console.WriteLine("2.Calcular area del triangulo");
            Console.WriteLine("3.Calcular perimetro del triangulo");
            Console.WriteLine("4.Calcular area y perimetro del triangulo");
            Console.WriteLine("");
            Console.WriteLine("0.Volver");
            this.Opcion2 = Convert.ToInt32(Console.ReadLine());
            return this.Opcion2;
        }

        /// <summary>
        /// Solicita el ingreso de la primer componente de un punto
        /// </summary>
        /// <returns>
        /// Regresa un 'double'
        /// </returns>
        public double PedirComponenteX()
        {
            Console.Write("X: ");
            return (Convert.ToDouble(Console.ReadLine()));
        }

        /// <summary>
        /// Solicita el ingreso de la segunda componente de un punto
        /// </summary>
        /// <returns>
        /// Regresa un 'double'
        /// </returns>
        public double PedirComponenteY()
        {
            Console.Write("Y: ");
            return (Convert.ToDouble(Console.ReadLine()));
        }

        /// <summary>
        /// Solicita el ingreso del radio de una circunferencia
        /// </summary>
        /// <returns>
        /// Regresa un 'double'
        /// </returns>
        public double PedirRadio()
        {
            Console.Write("Radio de la circunferencia: ");
            return (Convert.ToDouble(Console.ReadLine()));
        }

        /// <summary>
        /// Crea un punto
        /// </summary>
        /// <returns>
        /// Regresa un objeto de la clase Punto
        /// </returns>
        public Punto CrearPunto()
        {
            Console.Clear();
            Console.WriteLine("Coordenadas del punto");
            double puntoX = this.PedirComponenteX();
            double puntoY = this.PedirComponenteY();
            Punto punto = new Punto(puntoX,puntoY); //Crea un punto a partir de las coordenadas pedidas
            return punto;
        }

        /// <summary>
        /// Crea un circulo
        /// </summary>
        /// <returns>
        /// Regresa un objeto de la clase Circulo
        /// </returns>
        public Circulo CrearCirculo()
        {
            Console.Clear();
            Console.WriteLine("Coordenadas del centro");
            double centroX = this.PedirComponenteX();
            double centroY = this.PedirComponenteY();
            double radio = this.PedirRadio();
            Console.WriteLine("");
            Circulo circulo = new Circulo(centroX,centroY, radio); //Crea un circulo a partir de las coordenadas y el radio
            return circulo;
        }

        /// <summary>
        /// Crea un triangulo
        /// </summary>
        /// <returns>
        /// Regresa un objeto de la clase Triangulo
        /// </returns>
        public Triangulo CrearTriangulo()
        {           
            Console.Clear();
            Console.WriteLine("Coordenadas del primer punto");
            double punto1X = this.PedirComponenteX();
            double punto1Y = this.PedirComponenteY();
            Punto pPunto1 = new Punto(punto1X,punto1Y);
            Console.WriteLine("Coordenadas del segundo punto");
            double punto2X = this.PedirComponenteX();
            double punto2Y = this.PedirComponenteY();
            Punto pPunto2 = new Punto(punto2X,punto2Y);
            Console.WriteLine("Coordenadas del tercer punto");
            double punto3X = this.PedirComponenteX();
            double punto3Y = this.PedirComponenteY();
            Punto pPunto3 = new Punto(punto3X,punto3Y);
            Triangulo triangulo = new Triangulo(pPunto1, pPunto2, pPunto3); //Crea un triangulo a partir de los tres puntos
            return triangulo;
        }
    }
}
