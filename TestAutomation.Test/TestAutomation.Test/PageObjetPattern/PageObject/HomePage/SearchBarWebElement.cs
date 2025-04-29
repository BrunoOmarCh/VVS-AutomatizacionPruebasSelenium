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

    }
}
