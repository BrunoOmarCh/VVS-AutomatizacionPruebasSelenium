using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Xml.Linq;
using FluentAssertions;

namespace TestAutomation.Test.Inicio
{
    public class FristTest
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

    }
}
