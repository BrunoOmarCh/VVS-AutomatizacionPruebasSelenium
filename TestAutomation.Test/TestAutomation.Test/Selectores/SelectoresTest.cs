﻿using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Test.Selectores
{
    public class SelectoresTest
    {
        #pragma warning disable NUnit1032
        IWebDriver driver;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.Url = "https://curso.testautomation.es";
        }
        [TearDown]
        public void TearDownTest()
        {
            driver.Close();
        }
        [Test]
        public void GetEachOfTheElements()
        {
            driver.FindElement(By.Id("SelectorsWeb")).Click(); //selecciona el elemento de la web por Id.
        }
    }
}



