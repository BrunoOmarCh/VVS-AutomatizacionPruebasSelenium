using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Test.PageObjetPattern.PageObject.ShoppingCart
{
    public class ShoppingCartPageObject
    {
        private readonly IWebDriver driver;
        private IWebElement TotalPrice => driver.FindElement(By.Id("totalPrice"));

        public ShoppingCartPageObject(IWebDriver driver)
        {
            this.driver = driver;
        }


    }
}
