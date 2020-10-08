using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    class Tablero
    {
        private Partida iPartida;
        private int iCantidadIntentos;
        private String[] iPalabras;
        private String[] iEstadoPalabra;
        private String iLetrasUsadas;
        private String[] iDatosDePartida = new String[5];
        private String[][] iPartidasGuardadas = new String[5][];
        private int iCantidadGuardados;

        public int CantidadIntentos
        {
            get { return this.iCantidadIntentos; }
            set { this.iCantidadIntentos = value; }
        }

        public int CantidadGuardados
        {
            get { return this.iCantidadGuardados; }
            set { this.iCantidadGuardados = value; }
        }

        public String[] Palabras
        {
            get { return this.iPalabras; }
            set { this.iPalabras = value; }
        }

        public String[] EstadoPalabra
        {
            get { return this.iEstadoPalabra; }
            set { this.iEstadoPalabra = value; }
        }

        public String LetrasUsadas
        {
            get { return this.iLetrasUsadas; }
            set { this.iLetrasUsadas = value; }
        }

        public String[] DatosDePartida
        {
            get { return this.iDatosDePartida; }
            set { this.iDatosDePartida = value; }
        }

        public String[][] PartidasGuardadas
        {
            get { return this.iPartidasGuardadas; }
            set { this.iPartidasGuardadas = value; }
        }

        public String[] PalabrasDeterminadas(String[] pPalabras)
        {
            pPalabras[0] = "mariposa"; pPalabras[1] = "caracol"; pPalabras[2] = "abecedario";
            pPalabras[3] = "destornillador"; pPalabras[4] = "telefono"; pPalabras[5] = "escarabajo";
            pPalabras[6] = "rascacielos"; pPalabras[7] = "proyecto"; pPalabras[8] = "constitucion";
            pPalabras[9] = "conectividad"; pPalabras[10] = "despertador"; pPalabras[11] = "carburador";
            pPalabras[12] = "calculadora"; pPalabras[13] = "trapecio"; pPalabras[14] = "sinusoidal";
            pPalabras[15] = "extraterrestre"; pPalabras[16] = "operador"; pPalabras[17] = "manufactura";
            pPalabras[18] = "democracia"; pPalabras[19] = "estabilidad"; pPalabras[20] = "zodiaco";
            pPalabras[21] = "naturaleza"; pPalabras[22] = "xilofono"; pPalabras[23] = "parquimetro";
            pPalabras[24] = "heliocentrico"; pPalabras[25] = "limonada"; pPalabras[26] = "teclado";
            pPalabras[27] = "maquina"; pPalabras[28] = "vasija"; pPalabras[29] = "boligrafo";
            return pPalabras;
        }

        public Tablero(Partida pPartida)
        {
            this.iCantidadIntentos = 10;
            this.iPartida = pPartida;
            this.CantidadGuardados = 0;
            this.PartidasGuardadas[0] = new String[5];
            this.PartidasGuardadas[1] = new String[5];
            this.PartidasGuardadas[2] = new String[5];
            this.PartidasGuardadas[3] = new String[5];
            this.PartidasGuardadas[4] = new String[5];
        }

        public void IniciarJuego()
        {
            int opcion;
            int opcion2;
            do
            {
                this.PantallaInicial();
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        this.PantallaNombre();
                        iPartida.ElegirNombre(Console.ReadLine());
                        String[] aux = new String[30];
                        this.LetrasUsadas = "";
                        this.Palabras = this.PalabrasDeterminadas(aux);
                        iPartida.Palabra = iPartida.SeleccionarPalabra(this.Palabras);
                        aux = new String[iPartida.Palabra.Length];
                        this.DatosDePartida = new string[5];
                        for (int i = 0; i < aux.Length; i++)
                        {
                            aux[i] = "_";
                        }
                        iPartida.InicioPartida = iPartida.InicioPartida;
                        this.EstadoPalabra = aux;
                        do
                        {
                            this.PantallaIniciarPartida();
                            String letra = Console.ReadLine();
                            if (iPartida.PedirLetra(LetrasUsadas, letra) == false && (letra.Length == 1))
                            {
                                this.EstadoPalabra = this.Adivinar(letra);
                                this.LetrasUsadas += letra;
                            }
                            else
                            {
                                Console.WriteLine("Esta letra ya fue usada o es una entrada incorrecta, intentalo de nuevo");
                                Console.ReadKey();
                            }
                        } while (Terminado() == false);
                        GuardarDatos();
                        GuardarPartida();
                        OrdenarPartidas();
                        this.CantidadIntentos = 10;
                        break;
                    case 2:
                        do
                        {
                            this.PantallaAjustes();
                            opcion2 = Convert.ToInt32(Console.ReadLine());
                            switch (opcion2)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("                                   AHORCADO: EL JUEGO                  ");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.Write("                          Cantidad de intentos permitidos: ");
                                    this.CantidadIntentos = Convert.ToInt32(Console.ReadLine());
                                    break;
                                default:
                                    break;
                            }
                        } while (opcion2 != 0);
                        break;
                    case 3:
                        this.PantallaMejoresTiempos();
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (opcion != 0);
        }

        public void PantallaInicial()
        {
            Console.Clear();
            Console.WriteLine("                                   AHORCADO: EL JUEGO                  ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                   1.Iniciar partida                      ");
            Console.WriteLine("                                       2.Ajustes                          ");
            Console.WriteLine("                                   3.Mejores tiempos                      ");
            Console.WriteLine("");
            Console.WriteLine("                                        0.Salir                           ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                  2020, Axel Nieto                       ");
        }

        public void PantallaNombre()
        {
            Console.Clear();
            Console.WriteLine("                                   AHORCADO: EL JUEGO                  ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("                           Nombre del jugador: ");
        }

        public void PantallaIniciarPartida()
        {
            Console.Clear();
            Console.WriteLine("                                   AHORCADO: EL JUEGO                  ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("                             Palabra: " + this.DibujarPalabra(this.EstadoPalabra));
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                            Letras usadas: " + this.LetrasUsadas);
            Console.WriteLine("                            Intentos restantes: " + this.CantidadIntentos);
            Console.WriteLine("");
            Console.Write("Ingrese una Letra: ");
        }

        public void PantallaAjustes()
        {
            Console.Clear();
            Console.WriteLine("                                   AHORCADO: EL JUEGO                  ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                           1.Modificar cantidad de intentos               ");
            Console.WriteLine("");
            Console.WriteLine("                                       0.Volver                           ");
        }

        public void PantallaMejoresTiempos()
        {
            Console.Clear();
            Console.WriteLine("                                   AHORCADO: EL JUEGO                  ");
            Console.WriteLine("");
            Console.WriteLine("");
            for (int i = CantidadGuardados - 1; i >= 0; i--)
            {
                Console.WriteLine("                                     Nombre: " + PartidasGuardadas[i][0]);
                Console.WriteLine("                          Inicio de Partida: " + PartidasGuardadas[i][1]);
                Console.WriteLine("                             Fin de Partida: " + PartidasGuardadas[i][2]);
                Console.WriteLine("                                   Duracion: " + Math.Round(Convert.ToDouble(PartidasGuardadas[i][3]), 3) + " segundos");
                Console.WriteLine("                                   Victoria: " + PartidasGuardadas[i][4]);
                Console.WriteLine("");
                Console.WriteLine("");
            }
        }

        public String DibujarPalabra(String[] pPalabra)
        {
            String cadena = "";
            for (int i = 0; i < pPalabra.Length; i++)
            {
                cadena += pPalabra[i] + " ";
            }
            return cadena;
        }

        public String[] Adivinar(String pLetra)
        {
            String[] aux = this.EstadoPalabra;
            if (iPartida.PedirLetra(iPartida.Palabra, pLetra) == true)
            {
                for (int i = 0; i < iPartida.Palabra.Length; i++)
                {
                    if (Convert.ToString(iPartida.Palabra[i]).Equals(pLetra))
                    {
                        aux[i] = pLetra;
                    }
                }
            }
            else this.CantidadIntentos--;
            return aux;
        }

        public bool Terminado()
        {
            if (this.CantidadIntentos == 0)
            {
                iPartida.Victoria = false;
                return true;
            }
            else
            {
                String concat = String.Concat(this.EstadoPalabra);
                if (concat.Equals(iPartida.Palabra))
                {
                    iPartida.FinPartida = iPartida.FinPartida;
                    iPartida.Duracion = iPartida.Duracion;
                    iPartida.Victoria = true;
                    return true;
                }
                else return false;
            }
        }

        public void GuardarDatos()
        {
            String victoria;
            if (iPartida.Victoria == true)
            {
                victoria = "SI";
            }
            else
            {
                victoria = "NO";
            }
            this.DatosDePartida[0] = iPartida.ObtenerNombre();
            this.DatosDePartida[1] = Convert.ToString(iPartida.InicioPartida);
            this.DatosDePartida[2] = Convert.ToString(iPartida.FinPartida);
            this.DatosDePartida[3] = Convert.ToString(iPartida.Duracion);
            this.DatosDePartida[4] = victoria;
        }

        public void GuardarPartida()
        {
            if (this.CantidadGuardados < 5 && this.DatosDePartida[4] == "SI")
            {
                this.PartidasGuardadas[CantidadGuardados][0] = this.DatosDePartida[0];
                this.PartidasGuardadas[CantidadGuardados][1] = this.DatosDePartida[1];
                this.PartidasGuardadas[CantidadGuardados][2] = this.DatosDePartida[2];
                this.PartidasGuardadas[CantidadGuardados][3] = this.DatosDePartida[3];
                this.PartidasGuardadas[CantidadGuardados][4] = this.DatosDePartida[4];
                this.CantidadGuardados++;
            }
            else if (this.DatosDePartida[4] == "SI")
            {
                String[] mayor = new String[5];
                String[] aux = new String[5];
                mayor[0] = this.DatosDePartida[0];
                mayor[1] = this.DatosDePartida[1];
                mayor[2] = this.DatosDePartida[2];
                mayor[3] = this.DatosDePartida[3];
                mayor[4] = this.DatosDePartida[4];
                for (int i = 0; i < CantidadGuardados; i++)
                {
                    if (Convert.ToDouble(mayor[3]) < Convert.ToDouble(this.PartidasGuardadas[i][3]))
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            aux[j] = mayor[j];
                            mayor[j] = this.PartidasGuardadas[i][j];
                            this.PartidasGuardadas[i][j] = aux[j];
                        }
                    }
                }
            }
        }

        public void OrdenarPartidas()
        {
            String[] aux = new String[5];
            String[] aux2 = new String[5];
            for (int i = 0; i < CantidadGuardados; i++)
            {
                aux[0] = this.PartidasGuardadas[i][0];
                aux[1] = this.PartidasGuardadas[i][1];
                aux[2] = this.PartidasGuardadas[i][2];
                aux[3] = this.PartidasGuardadas[i][3];
                aux[4] = this.PartidasGuardadas[i][4];
                for (int j = i; j < CantidadGuardados; j++)
                {
                    aux2[0] = this.PartidasGuardadas[j][0];
                    aux2[1] = this.PartidasGuardadas[j][1];
                    aux2[2] = this.PartidasGuardadas[j][2];
                    aux2[3] = this.PartidasGuardadas[j][3];
                    aux2[4] = this.PartidasGuardadas[j][4];
                    if (Convert.ToDouble(aux[3]) < Convert.ToDouble(aux2[3]))
                    {
                        for (int k = 0; k < 5; k++)
                        {
                            this.PartidasGuardadas[i][k] = aux2[k];
                            this.PartidasGuardadas[j][k] = aux[k];
                            aux[k] = this.PartidasGuardadas[i][k];
                        }
                    }
                }
            }
        }
    }
}
