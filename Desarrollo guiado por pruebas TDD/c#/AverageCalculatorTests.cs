using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoraPromedio.Tests
{
    [TestClass]
    public class CalculadoraPromedioTests
    {
        [TestMethod]
        public void Promedio_DeArregloVacio_DebeSerCero()
        {
            // Arrange
            var calculadora = new CalculadoraPromedio();
            int[] conjunto = { };

            // Act
            var resultado = calculadora.CalcularPromedio(conjunto);

            // Assert
            Assert.AreEqual(0, resultado);
        }

        [TestMethod]
        public void Promedio_DeArregloConUnElemento_DebeSerElElemento()
        {
            // Arrange
            var calculadora = new CalculadoraPromedio();
            int[] conjunto = { 5 };

            // Act
            var resultado = calculadora.CalcularPromedio(conjunto);

            // Assert
            Assert.AreEqual(5, resultado);
        }

        [TestMethod]
        public void Promedio_DeArregloConMultiplesElementos_DebeSerCorrecto()
        {
            // Arrange
            var calculadora = new CalculadoraPromedio();
            int[] conjunto = { 1, 2, 3, 4, 5 };

            // Act
            var resultado = calculadora.CalcularPromedio(conjunto);

            // Assert
            Assert.AreEqual(3, resultado);
        }

        [TestMethod]
        public void Promedio_DeArregloConNumerosNegativos_DebeSerCorrecto()
        {
            // Arrange
            var calculadora = new CalculadoraPromedio();
            int[] conjunto = { -1, -2, -3, -4, -5 };

            // Act
            var resultado = calculadora.CalcularPromedio(conjunto);

            // Assert
            Assert.AreEqual(-3, resultado);
        }

        [TestMethod]
        public void Promedio_DeArregloConNumerosPositivosYNegativos_DebeSerCorrecto()
        {
            // Arrange
            var calculadora = new CalculadoraPromedio();
            int[] conjunto = { -1, 2, -3, 4, -5 };

            // Act
            var resultado = calculadora.CalcularPromedio(conjunto);

            // Assert
            Assert.AreEqual(-0.6, resultado, 0.0001);
        }

        [TestMethod]
        public void Promedio_DeArregloConNumerosGrandes_DebeSerCorrecto()
        {
            // Arrange
            var calculadora = new CalculadoraPromedio();
            int[] conjunto = { 1000000, 2000000, 3000000, 4000000, 5000000 };

            // Act
            var resultado = calculadora.CalcularPromedio(conjunto);

            // Assert
            Assert.AreEqual(3000000, resultado);
        }
    }
}

