using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomation.Test.PageObjetPattern.Factories;
using TestAutomation.Test.PageObjetPattern;

namespace TestAutomation.Test.VRP.Helpers
{
    public class UITestContextVRP
    {
        //esta clase se encargara de crear los drivers
        //y ponerlos a disposición cuando se demanden.
        //se maximiza, se carga el ImplicitWait y se navega a tu URL base.
        public IWebDriver Driver { get; set; }
        public UITestContextVRP()
        {
            //Driver = new ChromeDriver(); 
            Driver = WebDriverFactory.GetWebDriver(TestBase.TestSettings.Browser.ToLower());

        }

    }
}
