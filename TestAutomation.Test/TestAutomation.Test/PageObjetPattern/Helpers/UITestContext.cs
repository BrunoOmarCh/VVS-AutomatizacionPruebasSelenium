﻿using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomation.Test.PageObjetPattern.Factories;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace TestAutomation.Test.PageObjetPattern.Helpers
{
    public class UITestContext : IDisposable
    {
        //esta clase se encargara de crear los drivers y ponerlos a disposición cuando se demanden.
        public IWebDriver Driver { get; set; }
        public UITestContext()
        {
            //Driver = new ChromeDriver(); 
            Driver = WebDriverFactory.GetWebDriver(TestBase.TestSettings.Browser.ToLower());
            Driver.Manage().Window.Maximize();
            //Como ve, aque el timeout esta como 3, y debe ser cambiado
            //por la variable definida en el archivo json:
            Driver.Manage().Timeouts().ImplicitWait =
            TimeSpan.FromSeconds(TestBase.TestSettings.WaitTimeout);
            Driver.Url =
            "https://curso.testautomation.es/FruitVegetablesShopWeb/index.html";
        }
        public void Dispose()
        {
            Driver.Dispose();
        }
    }
}
