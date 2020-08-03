using System;
using TechTalk.SpecFlow;

namespace CalculadoraWindowsFormsAppTest
{
    [Binding]
    public class REQ_002_OperacionesIUSteps
    {
        [Given(@"Abrí la calculadora")]
        public void GivenAbriLaCalculadora()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"Ingresé el número (.*) en la calculadora")]
        public void GivenIngreseElNumeroEnLaCalculadora(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Ingresé la operación C")]
        public void WhenIngreseLaOperacionC()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"El resultado debiera ser (.*) en la pantalla")]
        public void ThenElResultadoDebieraSerEnLaPantalla(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Cerré la calculadora")]
        public void ThenCerreLaCalculadora()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
