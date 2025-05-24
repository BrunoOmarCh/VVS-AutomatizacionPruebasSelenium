using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Test.PageObjetPattern.Factories
{
    public static class WebDriverFactory
    {
        public static IWebDriver GetWebDriver(string browsername)
        {
            switch (browsername)
            {
                case "edge": return new EdgeDriver();
                case "chrome": return new ChromeDriver();

            }
        }
    }
}