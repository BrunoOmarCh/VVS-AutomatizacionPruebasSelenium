using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestAutomation.Test.PageObjetPattern.Helpers;
using TestAutomation.Test.PageObjetPattern.Models;
using TestAutomation.Test.PageObjetPattern.PageObject.ContacUs;
using TestAutomation.Test.PageObjetPattern.PageObject.ShoppingCart;


namespace TestAutomation.Test.PageObjetPattern.PageObject.HomePage
{
    public class HomePageObject
    {
        private readonly IWebDriver driver; //definiendo el driver

        // definimos el contructor
        public HomePageObject(IWebDriver driver)
        {
            this.driver = driver;
        }

        //para las frutas que seran una lista
        private List<IWebElement> DisplayedFruits =>
            driver.FindElements(By.ClassName("fruit")).Where(fruit =>
            fruit.Displayed).ToList();

        public PageBarWebElement PageNavegation => new PageBarWebElement(driver);

        //para mostrar la lista de frutas.
        public IList<FruitWebElement> DisplayedFruitWebElements()
        {
            return FruitHelpers.Parse(DisplayedFruits);
        }

        // metod que muestre la lista de frutas
        public IList<FruitModel> DisplayedFruitModel() =>
        FruitHelpers.Parse(DisplayedFruitWebElements());

        // metodos para el segundo test
        public SearchBarWebElement SearchBar => new SearchBarWebElement(driver);

        //metodo para el carrito de compras: TEST 3
        private IWebElement ShoppingCartIcon => driver.FindElement(By.Id("cart-icon"));
        public int GetShoppingCartIconNumberOfItem() =>
            int.Parse(ShoppingCartIcon.Text);
        public bool IsShoppingCartIconNumberOfItems(int number)
        {
            try
            {
                WaitHelper.WaitForCondition(() =>
                int.Parse(ShoppingCartIcon.Text).Equals(number));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //para abrir el carro de compras
        public ShoppingCartPageObject ClickShoppingCartIcon()
        {
            ShoppingCartIcon.Click();
            return new ShoppingCartPageObject(driver);
        }

    }
}