using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomation.Test.PageObjetPattern.Helpers;
using TestAutomation.Test.PageObjetPattern.Models;


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


    }
}