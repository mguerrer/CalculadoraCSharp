using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoraTest
{
    [TestClass]

    public class CalculadoraCoreUnitTestsBasicOps
    {
        [TestMethod]
        public void Suma1mas2Igual3()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            double Resultado=0;
            string C�digoRetorno = calculadora.Suma(1, 2, ref Resultado);

            // Assert
            Assert.AreEqual(C�digoRetorno, "OK");
            Assert.AreEqual(Resultado, 3);
        }
        [TestMethod]
        public void Resta6menos2Igual4()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            double Resultado = 0;
            string C�digoRetorno = calculadora.Resta(6, 2, ref Resultado);

            // Assert
            Assert.AreEqual(C�digoRetorno, "OK");
            Assert.AreEqual(Resultado, 4);
        }
        [TestMethod]
        public void Multiplica6x2Igual12()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            double Resultado = 0;
            string C�digoRetorno = calculadora.Multiplica(6, 2, ref Resultado);

            // Assert
            Assert.AreEqual(C�digoRetorno, "OK");
            Assert.AreEqual(Resultado, 12);
        }
        [TestMethod]
        public void Divide6por2Igual3()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            double Resultado = 0;
            string C�digoRetorno = calculadora.Divide(6, 2, ref Resultado);

            // Assert
            Assert.AreEqual(C�digoRetorno, "OK");
            Assert.AreEqual(Resultado, 3);
        }
    }

    [TestClass]
    public class CalculadoraCoreUnitTestsInterfaceOps
    {
        [TestMethod]
        public void Suma1mas2Igual3()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            double Resultado = 0;
            string C�digoRetorno = calculadora.Suma(1, 2, ref Resultado);

            // Assert
            Assert.AreEqual(C�digoRetorno, "OK");
            Assert.AreEqual(Resultado, 3);
        }
        [TestMethod]
        public void Resta6menos2Igual4()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            double Resultado = 0;
            string C�digoRetorno = calculadora.Resta(6, 2, ref Resultado);

            // Assert
            Assert.AreEqual(C�digoRetorno, "OK");
            Assert.AreEqual(Resultado, 4);
        }
        [TestMethod]
        public void Multiplica6x2Igual12()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            double Resultado = 0;
            string C�digoRetorno = calculadora.Multiplica(6, 2, ref Resultado);

            // Assert
            Assert.AreEqual(C�digoRetorno, "OK");
            Assert.AreEqual(Resultado, 12);
        }
        [TestMethod]
        public void Divide6por2Igual3()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            double Resultado = 0;
            string C�digoRetorno = calculadora.Divide(6, 2, ref Resultado);

            // Assert
            Assert.AreEqual(C�digoRetorno, "OK");
            Assert.AreEqual(Resultado, 3);
        }
    }



}
