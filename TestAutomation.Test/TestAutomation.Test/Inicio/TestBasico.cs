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
        [Test]
        public void TestBasicWebPage()
        {
            //Normal load website
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize(); // sentencia para maximizar navegador
            driver.Url = "https://curso.testautomation.es"; //para navegar a la pj web que vamos a testear
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
            var titulo = driver.FindElement(By.Id("title"));//para obtener el elemento que tiene title
            titulo.Text.Should().Be("Slow load website"); //para obtener el valor texto.
            driver.Quit(); 
        }
        [Test]
        public void TestSlowLoadTextWebPage()
        {
            //Slow load text website

        }
    }
}
