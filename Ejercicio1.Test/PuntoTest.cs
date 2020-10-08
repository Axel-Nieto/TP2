using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Ejercicio1.Test
{
    public class PuntoTest
    {
        [Fact]
        public void Test_Punto_CalcularDistanciaEntrePuntos()
        {
            //Arrange
            var punto1 = new Punto(1, 6);
            var punto2 = new Punto(3, -5);
            var resultadoEsperado = 11.18;

            //Act
            var distancia = punto1.CalcularDistanciaDesde(punto2);

            //Assert
            Assert.Equal(resultadoEsperado,distancia);
        }
    }
}
