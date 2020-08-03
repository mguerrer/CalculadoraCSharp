using CalculadoraCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoraCoreUnitTest
{
    /// <summary>
    /// sd
    /// </summary>
    [TestClass]
    public class CalculadoraTests
    {
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]

        public void Suma1mas2Igual3()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            double Resultado=0;
            string CódigoRetorno = calculadora.Suma(1, 2, ref Resultado);

            // Assert
            Assert.AreEqual(CódigoRetorno, "OK");
            Assert.AreEqual(Resultado, 3);
        }
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]

        public void Resta6menos2Igual4()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            double Resultado = 0;
            string CódigoRetorno = calculadora.Resta(6, 2, ref Resultado);

            // Assert
            Assert.AreEqual(CódigoRetorno, "OK");
            Assert.AreEqual(Resultado, 4);
        }
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]

        public void Multiplica6x2Igual12()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            double Resultado = 0;
            string CódigoRetorno = calculadora.Multiplica(6, 2, ref Resultado);

            // Assert
            Assert.AreEqual(CódigoRetorno, "OK");
            Assert.AreEqual(Resultado, 12);
        }
        [TestMethod]

        public void Divide6por2Igual3()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            double Resultado = 0;
            string CódigoRetorno = calculadora.Divide(6, 2, ref Resultado);

            // Assert
            Assert.AreEqual(CódigoRetorno, "OK");
            Assert.AreEqual(Resultado, 3);
        }
    }
}
