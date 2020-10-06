using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador jugador = new Jugador();
            Partida partida = new Partida(jugador);
            Tablero tablero = new Tablero(partida);
            tablero.IniciarJuego();
        }
    }
}
