using System;

namespace CalculadoraCore
{
    /// <summary>
    /// Core operacional de la calculadora.  Demo para ACL.
    /// </summary>
    public class Calculadora
    {
        /// <summary>
        /// Suma dos valores.
        /// </summary>
        /// <param name="num1">Primer valor</param>
        /// <param name="num2">Segundo valor</param>
        /// <param name="result">Resultado por referencia</param>
        /// <returns>Código que indica si funcionó.  "OK" si todo bien, sino texto de excepción....</returns>
        public string Suma(double num1, double num2, ref double result)
        {
            try
            {
                result = num1 + num2;
                return "OK";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        /// <summary>
        /// Resta dos valores
        /// </summary>
        /// <param name="num1">Primer valor</param>
        /// <param name="num2">Segundo valor</param>
        /// <param name="result">Resultado por referencia</param>
        /// <returns>Código que indica si funcionó.  "OK" si todo bien, sino texto de excepción.</returns>
        public string Resta(double num1, double num2, ref double result)
        {
            try
            {
                result = num1 - num2;
                return "OK";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        /// <summary>
        /// Multiplica dos valores
        /// </summary>
        /// <param name="num1">Primer valor</param>
        /// <param name="num2">Segundo valor</param>
        /// <param name="result">Resultado por referencia</param>
        /// <returns>Código que indica si funcionó.  "OK" si todo bien, sino texto de excepción.</returns>
        public string Multiplica(double num1, double num2, ref double result)
        {
            try
            {
                result = num1 * num2;
                return "OK";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        /// <summary>
        /// Divide dos valores
        /// </summary>
        /// <param name="num1">Primer valor</param>
        /// <param name="num2">Segundo valor</param>
        /// <param name="result">Resultado por referencia</param>
        /// <returns>Código que indica si funcionó.  "OK" si todo bien, sino texto de excepción.</returns>
        public string Divide(double num1, double num2, ref double result)
        {
            try
            {
                result = num1 / num2;
                return "OK";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}