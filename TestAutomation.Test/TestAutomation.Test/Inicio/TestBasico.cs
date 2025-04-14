using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Xml.Linq;
using FluentAssertions;

namespace TestAutomation.Test.Inicio
{
    [TestFixture]
    public class TestBasico
    {
        [SetUp]
        public void SetUp()
        {
            //Resolver la duplicidad de codigo
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize(); // sentencia para maximizar navegador
            driver.Url = "https://curso.testautomation.es"; //para navegar a la pj web que vamos a testear
        }
        [Test]
        public void TestBasicWebPage()
        {
            //Normal load website
            var normalLoadWeb = driver.FindElement(By.Id("NormalWeb"));// para ubicar por id el elemento de la pagina
            normalLoadWeb.Click();// para hacer click en el elemento.
            var titulo = driver.FindElement(By.CssSelector("h1"));//para obtener el elemento que tine el tag h1
            titulo.Text.Should().Be("Normal load website"); //para obtener el valor texto.
            driver.Quit(); //para liberar los recursos
        }
        [Test]
        public void TestSlowLoadWebPage()
        {
            //Slow load website
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://curso.testautomation.es"; 
            var slowLoadWeb = driver.FindElement(By.Id("SlowLoadWeb"));
            slowLoadWeb.Click();
            Thread.Sleep(3000);// esto pausa la ejecucion x 3 segundos
            //Falla porque la página tarda unos segundos en cargar, Selenium intenta ubicar el elemento inmediatamente
            //Lo que provoca un error porque aún no ha aparecido en el DOM.
            var titulo = driver.FindElement(By.Id("title"));//para obtener el elemento que tiene title
            titulo.Text.Should().Be("Slow load website"); //para obtener el valor texto.
            driver.Quit(); 
        }
        [Test]
        public void TestSlowLoadTextWebPage()
        {
            //Slow load text website
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize(); // sentencia para maximizar navegador
            driver.Url = "https://curso.testautomation.es"; //para navegar a la pj web que vamos a testear
            var slowLoadTextWeb = driver.FindElement(By.Id("SlowSpeedTextWeb")); // para ubicar por id el elemento de la pagina
            slowLoadTextWeb.Click();
            Thread.Sleep(1500);
            //La página carga el texto del título con un pequeño retardo (1 segundo) .
            //El test falla porque intenta leer el texto antes de que se haya cargado.
            var titulo = driver.FindElement(By.Id("title"));
            titulo.Text.Should().Be("Slow load website");
            driver.Quit();

        }
    }
}
