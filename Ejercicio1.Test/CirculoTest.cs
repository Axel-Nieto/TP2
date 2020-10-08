using System;
using Ejercicio1;
using Xunit;

namespace Ejercicio1.Test
{
    public class CirculoTest
    {
        [Fact]
        public void Test_Circulo_Area()
        {
            //Preparacion
            var circulo = new Circulo(0,0,10);

            //Ejecucion
            var area = circulo.Area();

            //Validacion
            Assert.Equal(314.16, area);
        }
    }
}
