// MsTest tests
// See documentation : https://github.com/ObjectivityLtd/Ocaramba 

namespace Ocaramba.UITests.MsTest.NetCore
{

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using PageObjects;

    //[TestClass]
    public class HerokuappTestsMsTest : ProjectTestBase
    {
        //[TestMethod]
        public void TickCheckboxTest()
        {
            // TODO: Add your test code here
            var checkboxes = new InternetPage(this.DriverContext);
            checkboxes.OpenHomePage();
        }

        //[TestMethod]
        public void UnTickCheckboxTest()
        {
            // TODO: Add your test code here
            var checkboxes = new InternetPage(this.DriverContext);
            checkboxes.OpenHomePage();
        }
    }
}
