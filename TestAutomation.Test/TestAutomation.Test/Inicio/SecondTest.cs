﻿using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace TestAutomation.Test.Inicio
{
    public class SecondTest
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
            driver.Url = "https://curso.testautomation.es"; //para navegar a la pj web que vamos a testear
        }
        [TearDown]
        public void TearDown()
        {
            //2.Ahora resolveremos los del driver.Quit().
            driver.Quit(); //para liberar los recursos
        }

        [Test]
        public void TestBasicWebPage()
        {
            //Normal load website
            var normalLoadWeb = driver.FindElement(By.Id("NormalWeb"));// para ubicar por id el elemento de la pagina
            normalLoadWeb.Click();// para hacer click en el elemento.
            var titulo = driver.FindElement(By.CssSelector("h1"));//para obtener el elemento que tine el tag h1
            titulo.Text.Should().Be("Normal load website"); //para obtener el valor texto.
        }

    }
}
