using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace TestAutomation.Test.Inicio
{
    [TestFixture]
    public class ThreeCode
    {
        #pragma warning disable NUnit1032
        ChromeDriver driver;
        [SetUp]
        public void SetUp()
        {
            // todo lo que este dentro del SetUp se ejecutara antes de cualquier metodo
            //1. Resolver la duplicidad de codigo
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize(); // sentencia para maximizar navegador
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            //Esta indica a Selenium q cuando busqye un elemento lo haga por 3 segundos
            driver.Url = "https://curso.testautomation.es"; //para navegar a la pj web que vamos a testear
        }
    }
}
