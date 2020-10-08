using System;
using Xunit;

namespace Ejercicio2.Test
{
    public class RepositorioBancaTest
    {
        [Fact]
        public void Test_RepositorioBanca_Agregar_Nuevo()
        {
            //Arrange
            var repositorio = new RepositorioBanca();
            var banca = new Banca("36044207", "Axel");
            var banca2 = new Banca("36044210", "Jorge");
            var resultadoEsperado = banca;

            //Act
            repositorio.Agregar(banca);
            repositorio.Agregar(banca2);
            var obtener = repositorio.Obtener(banca.Numero);

            //Assert
            Assert.Equal(resultadoEsperado, obtener);
        }

        [Fact]
        public void Test_RepositorioBanca_Agregar_Existente()
        {
            //Arrange
            var repositorio = new RepositorioBanca();
            var banca = new Banca("36044207", "Axel");
            var banca2 = new Banca("36044207", "Jorge");

            //Act
            repositorio.Agregar(banca);
            repositorio.Agregar(banca2);
            var obtener = repositorio.Obtener(banca.Numero);

            //Assert
            Assert.Equal(banca2.Titular, obtener.Titular);
        }

        [Fact]
        public void Test_RepositorioBanca_Obtener_Positivo()
        {
            //Arrange
            var repositorio = new RepositorioBanca();
            var resultadoEsperado = new Banca("36044207", "Axel");

            //Act
            repositorio.Agregar(resultadoEsperado);
            var obtener = repositorio.Obtener("36044207");

            //Assert
            Assert.Equal(resultadoEsperado,obtener);
        }

        [Fact]
        public void Test_RepositorioBanca_Obtener_Negativo()
        {
            //Arrange
            var repositorio = new RepositorioBanca();
            var cuenta = new Banca("36044207", "Axel");
            Banca resultadoEsperado = null;

            //Act
            repositorio.Agregar(cuenta);
            var obtener = repositorio.Obtener("36044208");

            //Assert
            Assert.Equal(resultadoEsperado, obtener);
        }
    }
}
