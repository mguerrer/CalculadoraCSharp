using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CalculatorAppiumTest
{
    public class WindowsCalculatorPage : AppiumSession
    {
        public string Title = "Estándar",
                        ClearButton = "Borrar",
                        AddButton = "Más",
                        MinusButton = "Menos",
                        MultiplicationButton = "Multiplicar por",
                        DivisionButton = "Dividido por",
                        EqualButton = "Es igual a";

        public string[] NumberKeys = { "Cero", "Uno", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve" };
        public WindowsCalculatorPage()
        {

        }
        public void IntroNumber(string number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                char digit = number[i];
                string KeyName = digit.ToString();
                int KeyNameIndex = Int32.Parse(KeyName);
                try
                {
                    session.FindElementByName(NumberKeys[KeyNameIndex]).Click();
                }
                catch (Exception e)
                {
                    System.Console.WriteLine("Error on typing {0} in digit {1}.  \nStack:\n {3}", number, i, e.Message);
                }
            }
        }
        public void IntroOperation(string operation)
        {

            string OperationButtonName = "";
            try
            {
                switch (operation)
                {
                    case "+":
                        OperationButtonName = AddButton;
                        break;
                    case "-":
                        OperationButtonName = MinusButton;
                        break;
                    case "/":
                        OperationButtonName = DivisionButton;
                        break;
                    case "*":
                        OperationButtonName = MultiplicationButton;
                        break;
                    case "=":
                        OperationButtonName = EqualButton;
                        break;
                    case "C":
                        OperationButtonName = ClearButton;
                        break;
                }
                session.FindElementByName(OperationButtonName).Click();
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Error on operation {0}.  \nStack:\n {3}", operation, e.Message);
            }
        }
    }
}
