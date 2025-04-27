﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Test.PageObjetPattern.PageObject.HomePage
{
    public class PageBarWebElement
    {
        private readonly IWebDriver driver;
        // el constructo de la clase
        public PageBarWebElement(IWebDriver driver)
        {
            this.driver = driver;
        }
        // necesitamos definir los botones de navegacion entre paginas
        private IWebElement ButtonPage1 =>
        driver.FindElement(By.Id("page1Button"));
        private IWebElement ButtonPage2 =>
        driver.FindElement(By.Id("page2Button"));
        private IWebElement ButtonPage3 =>
        driver.FindElement(By.Id("page3Button"));

        //accion de click sobre los botones
        public HomePageObject ClickButtonPage1()
        {
            ButtonPage1.Click();
            return new HomePageObject(driver);
        }

    }
}
