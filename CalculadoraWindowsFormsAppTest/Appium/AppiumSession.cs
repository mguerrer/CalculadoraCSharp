//******************************************************************************
//
// Copyright (c) 2017 Microsoft Corporation. All rights reserved.
//
// This code is licensed under the MIT License (MIT).
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
//******************************************************************************

using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;

namespace CalculatorAppiumTest
{
    public class AppiumSession
    {
        // Note: append /wd/hub to the URL if you're directing the test at Appium
        private const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
        private const string CalculatorAppId = "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App";

        protected static WindowsDriver<WindowsElement> session=null;
        public static WindowsElement Header;

        public static void Setup()
        {
            // Create a new session to bring up an instance of the Calculator application
            // Note: Multiple calculator windows (instances) share the same process Id
            DesiredCapabilities appCapabilities = new DesiredCapabilities();
            appCapabilities.SetCapability("app", CalculatorAppId);
            appCapabilities.SetCapability("deviceName", "WindowsPC");
            session = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), appCapabilities);
            //Assert.IsNotNull(session);
            if (session == null)
                throw new SystemException("Can not open WinAppDriver session.");

            // Set implicit timeout to 1.5 seconds to make element search to retry every 500 ms for at most three times
            session.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1.5);
        }

        public void CloseCalculator()
        {
            // Close the application and delete the session
            if (session != null)
            {
                session.Quit();
                session = null;
            }
        }
        public String GetCalculatorResultText()
        {
            //return calculatorResult.Text.Replace("Display is", string.Empty).Trim();
            //return CalculatorResult.Text.Replace("La pantalla muestra", string.Empty).Trim();
            // Locate the calculatorResult element
            try
            {
                WindowsElement CalculatorResult = session.FindElementByAccessibilityId("CalculatorResults");
                return CalculatorResult.Text.Replace("Se muestra", string.Empty).Trim();
            }
            catch (Exception e)
            {
                return e.Message;
            }
            
        }

    }
}
