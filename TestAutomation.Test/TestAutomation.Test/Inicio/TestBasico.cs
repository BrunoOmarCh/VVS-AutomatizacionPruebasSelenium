using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Xml.Linq;
using FluentAssertions;
using System.Diagnostics;
using System;

namespace TestAutomation.Test.Inicio
{
    [TestFixture]
    public class TestBasico
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
        [Test]
        public void TestSlowLoadWebPage()
        {
            //Slow load website
            var slowLoadWeb = driver.FindElement(By.Id("SlowLoadWeb"));
            slowLoadWeb.Click();
            //Falla porque la página tarda unos segundos en cargar, Selenium intenta ubicar el elemento inmediatamente
            //Lo que provoca un error porque aún no ha aparecido en el DOM.
            var titulo = driver.FindElement(By.Id("title"));//para obtener el elemento que tiene title
            titulo.Text.Should().Be("Slow load website"); //para obtener el valor texto.
        }
        [Test]
        public void TestSlowLoadTextWebPage()
        {
            //Slow load text website
            var slowLoadTextWeb = driver.FindElement(By.Id("SlowSpeedTextWeb")); // para ubicar por id el elemento de la pagina
            slowLoadTextWeb.Click();
            //La página carga el texto del título con un pequeño retardo (1 segundo) .
            //El test falla porque intenta leer el texto antes de que se haya cargado.
            var titulo = driver.FindElement(By.Id("title"));
            titulo.Text.Should().Be("Slow load website");
        }

        private void WaitForCondition(Func<bool> condition, int msTimeout = 4000)
        {
            // este codigo es muy util para controlar l
            var stopWatch = new Stopwatch(); // definimos una variable de tipo Stopwatch
            stopWatch.Start(); //iniciamos la variable.
           
        }
    }
}



