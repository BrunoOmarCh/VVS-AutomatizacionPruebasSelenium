using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;

namespace TestAutomation.Test.PageObjetPattern.PageObject.HomePage
{
    public class SearchBarWebElement
    {
        private readonly IWebDriver driver;
        // el constrctor
        public SearchBarWebElement(IWebDriver driver)
        {
            this.driver = driver;
        }
        // la barra de input y boton sarch esta no sera publica
        private IWebElement InputSearchProduct => driver.FindElement(By.Id("product-search"));
        private IWebElement ButtonSearch => driver.FindElement(By.Id("search-button"));
        // acciones del input y boton search
        public SearchBarWebElement InputSearch(string termToSearch)
        {
            InputSearchProduct.Clear();
            InputSearchProduct.SendKeys(termToSearch);
            return this;
        }
        //pulsamos click sobre el boton
        public HomePageObject ClickSearch()
        {
            ButtonSearch.Click();
            return new HomePageObject(driver);
        }
        //pulsando Enter
        public HomePageObject ClickEnter()
        {
            new Actions(driver)
            .SendKeys(Keys.Enter)
            .Perform();
            return new HomePageObject(driver);
        }
    }
}
