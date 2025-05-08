using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using TestAutomation.Test.PageObjetPattern.Models;
using TestAutomation.Test.PageObjetPattern.PageObject.HomePage;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestAutomation.Test.PageObjetPattern
{
    public class FreshMarketTests
    {
        #pragma warning disable NUnit1032
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.Url =
            "https://curso.testautomation.es/FruitVegetablesShopWeb/index.html";
        }

        [TearDown]
        public void TearDownTest()
        {
            driver.Quit();
        }

    }
}
