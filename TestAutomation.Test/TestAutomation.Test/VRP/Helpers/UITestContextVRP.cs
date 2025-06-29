﻿using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomation.Test.PageObjetPattern.Factories;
using TestAutomation.Test.PageObjetPattern;

namespace TestAutomation.Test.VRP.Helpers
{
    public class UITestContextVRP : IDisposable
    {
        //esta clase se encargara de crear los drivers
        //y ponerlos a disposición cuando se demanden.
        //se maximiza, se carga el ImplicitWait y se navega a tu URL base.
        public IWebDriver Driver { get; set; }
        public UITestContextVRP()
        {
            //Driver = new ChromeDriver(); 
            Driver = WebDriverFactory.GetWebDriver(TestBase.TestSettings.Browser.ToLower());
            Driver.Manage().Window.Maximize();
            //Como ve, aque el timeout esta como 3, y debe ser cambiado
            //por la variable definida en el archivo json:
            Driver.Manage().Timeouts().ImplicitWait =
            TimeSpan.FromSeconds(TestBase.TestSettings.WaitTimeout);
            Driver.Url =
            "http://localhost:5173/";
        }
        public void Dispose()
        {
            Driver.Dispose();
        }
    }
}
