using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Ejercicio1
{
    public class Facade
    {
        private UI iMenu;
        private Punto iPunto1;
        private Punto iPunto2;
        private Punto iPunto3;
        private Triangulo iTriangulo;
        private Circulo iCirculo;

        /// <summary>
        /// Instancia de la fachada del programa
        /// </summary>
        public Facade()
        {
            this.iMenu = new UI();
            this.iPunto1 = new Punto();
            this.iPunto2 = new Punto();
            this.iPunto3 = new Punto();
        }

        /// <summary>
        /// Inicia el programa
        /// </summary>
        public void IniciarPrograma()
        {
            int opcion;
            do
            {
                opcion = this.MenuPrincipalAcciones();
            } while (opcion != 0);
        }

        /// <summary>
        /// Imprime el menu principal, solicita una opcion y se realiza una accion en base a su valor
        /// </summary>
        /// <returns>
        /// Regresa el valor ingresado para operar en el menu
        /// </returns>
        public int MenuPrincipalAcciones()
        {
            int opcion = iMenu.MenuPrincipal();
            int opcion2;
            switch (opcion){
                case 1:
                    iPunto1 = this.CrearPunto();
                    iPunto2 = this.CrearPunto();
                    do
                    {
                        opcion2 = this.MenuSecundarioPuntosAcciones();
                    } while (opcion2 != 0);
                    break;
                case 2:
                    iCirculo = this.CrearCirculo();
                    do
                    {
                        opcion2 = this.MenuSecundarioCirculoAcciones();
                    } while (opcion2 != 0);
                    break;
                case 3:
                    iTriangulo = this.CrearTriangulo();
                    do
                    {
                        opcion2 = this.MenuSecundarioTrianguloAcciones();
                    } while (opcion2 != 0);
                    break;
            }
            return opcion;
        }

        /// <summary>
        /// Imprime el menu para operar con puntos, solicita una opcion y se realiza una accion en base a su valor
        /// </summary>
        /// <returns>
        /// Regresa el valor ingresado para operar en el menu
        /// </returns>
        public int MenuSecundarioPuntosAcciones()
        {
            int opcion2 = iMenu.MenuSecundarioPuntos();
            switch (opcion2)
            {
                case 1:
                    iPunto1 = this.CrearPunto();
                    iPunto2 = this.CrearPunto();
                    break;
                case 2:
                    Console.WriteLine("La distancia entre los puntos es: " + iPunto1.CalcularDistanciaDesde(iPunto2));
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
            return opcion2;
        }

        /// <summary>
        /// Imprime el menu para operar con circulos, solicita una opcion y se realiza una accion en base a su valor
        /// </summary>
        /// <returns>
        /// Regresa el valor ingresado para operar en el menu
        /// </returns>
        public int MenuSecundarioCirculoAcciones()
        {
            int opcion2 = iMenu.MenuSecundarioCirculo();
            switch (opcion2)
            {
                case 1:
                    iCirculo = this.CrearCirculo();
                    break;
                case 2:
                    Console.WriteLine("El area del circulo es: " + iCirculo.Area());
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("El perimetro del circulo es: " + iCirculo.Perimetro());
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("El area del circulo es: " + iCirculo.Area());
                    Console.WriteLine("El perimetro del circulo es: " + iCirculo.Perimetro());
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
            return opcion2;
        }

        /// <summary>
        /// Imprime el menu para operar con triangulos, solicita una opcion y se realiza una accion en base a su valor
        /// </summary>
        /// <returns>
        /// Regresa el valor ingresado para operar en el menu
        /// </returns>
        public int MenuSecundarioTrianguloAcciones()
        {
            int opcion2 = iMenu.MenuSecundarioTriangulo();
            switch (opcion2)
            {
                case 1:
                    iTriangulo = this.CrearTriangulo();
                    break;
                case 2:
                    Console.WriteLine("El area del triangulo es: " + iTriangulo.Area());
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("El perimetro del triangulo es: " + iTriangulo.Perimetro());
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("El area del triangulo es: " + iTriangulo.Area());
                    Console.WriteLine("El perimetro del triangulo es: " + iTriangulo.Perimetro());
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
            return opcion2;
        }

        /// <summary>
        /// Crea un punto
        /// </summary>
        /// <returns>Regresa un objeto de la clase Punto</returns>
        public Punto CrearPunto()
        {
            return iMenu.CrearPunto();
        }

        /// <summary>
        /// Crea un circulo
        /// </summary>
        /// <returns>Regresa un objeto de la clase Circulo</returns>
        public Circulo CrearCirculo()
        {
           return iMenu.CrearCirculo();
        }

        /// <summary>
        /// Crea un triangulo
        /// </summary>
        /// <returns>Regresa un objeto de la clase Triangulo</returns>
        public Triangulo CrearTriangulo()
        {
            return iMenu.CrearTriangulo();
        }
    }
}
