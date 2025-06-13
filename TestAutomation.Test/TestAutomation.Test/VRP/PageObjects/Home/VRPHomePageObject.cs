using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomation.Test.PageObjetPattern.Helpers;
using TestAutomation.Test.PageObjetPattern.PageObject.ShoppingCart;
using TestAutomation.Test.VRP.PageObjects.Login;


namespace TestAutomation.Test.VRP.PageObjects.Home
{
    public class VRPHomePageObject
    {
        private readonly IWebDriver driver;
        private IWebElement SubmitButton => driver.FindElement(By.CssSelector(".formBox_button"));
        public VRPHomePageObject(IWebDriver driver)
        {
            this.driver = driver;
        }

    }
}
