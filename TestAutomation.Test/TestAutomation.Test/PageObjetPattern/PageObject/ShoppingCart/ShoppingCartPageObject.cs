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
        private IWebElement ButtonClose => driver.FindElement(By.Id("CloseCart"));
        private List<IWebElement> Cartitems => driver.FindElements(By.ClassName(
            "cart-item")).ToList();
        public IEnumerable<CartItemWebElement> CartItemWebElements => Cartitems.
            Select(item => new CartItemWebElement(item));

        public ShoppingCartPageObject(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void ClickButtonClose() => ButtonClose.Click();
        public decimal GetTotalPrice() => decimal.Parse(TotalPrice.Text);
        public decimal GetTotalPriceFromItems() => CartItemWebElements.Sum(item => item.GetTotalPrice());

    }
}
