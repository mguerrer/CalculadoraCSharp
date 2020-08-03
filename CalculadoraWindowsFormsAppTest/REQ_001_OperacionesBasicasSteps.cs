using System;
using TechTalk.SpecFlow;

namespace CalculadoraWindowsFormsAppTest
{
    [Binding]
    public class REQ_001_OperacionesBasicasSteps
    {
        [Given(@"Ingresé la operación \+ en la calculadora")]
        public void GivenIngreseLaOperacionMasEnLaCalculadora()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"Ingresé la operación - en la calculadora")]
        public void GivenIngreseLaOperacionMenos_EnLaCalculadora()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"Ingresé la operación \* en la calculadora")]
        public void GivenIngreseLaOperacionMultiplicaciónEnLaCalculadora()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"Ingresé la operación / en la calculadora")]
        public void GivenIngreseLaOperacionDivisiónEnLaCalculadora()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Ingresé la operación =")]
        public void WhenIngreseLaOperacion()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Ingresé la operación (.*)")]
        public void WhenIngreseLaOperacion(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
