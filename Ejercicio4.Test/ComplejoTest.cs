using System;
using Xunit;

namespace Ejercicio4.Test
{
    public class ComplejoTest
    {
        [Fact]
        public void Test_Complejo_Suma()
        {
            //Arrange
            var complejo1 = new Complejo(3,8);
            var complejo2 = new Complejo(9,1);
            var resultado = new Complejo(12,9);

            //Act
            var suma = complejo1.Sumar(complejo2);

            //Assert
            Assert.Equal(Convert.ToString(resultado),Convert.ToString(suma));
        }

        [Fact]
        public void Test_Complejo_Resta()
        {
            //Arrange
            var complejo1 = new Complejo(3, 8);
            var complejo2 = new Complejo(9, 1);
            var resultado = new Complejo(-6,7);

            //Act
            var resta = complejo1.Restar(complejo2);

            //Assert
            Assert.Equal(Convert.ToString(resultado), Convert.ToString(resta));
        }

        [Fact]
        public void Test_Complejo_Multiplicacion()
        {
            //Arrange
            var complejo1 = new Complejo(3, 8);
            var complejo2 = new Complejo(9, 1);
            var resultado = new Complejo(19,75);

            //Act
            var multiplicacion = complejo1.MultiplicarPor(complejo2);

            //Assert
            Assert.Equal(Convert.ToString(resultado), Convert.ToString(multiplicacion));
        }

        [Fact]
        public void Test_Complejo_Division()
        {
            //Arrange
            var complejo1 = new Complejo(3, 8);
            var complejo2 = new Complejo(9, 1);
            var resultado = new Complejo(35/82, 69/82);

            //Act
            var division = complejo1.DividirPor(complejo2);

            //Assert
            Assert.Equal(Convert.ToString(resultado),Convert.ToString(division));
        }
    }
}
