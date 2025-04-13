using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Xml.Linq;

namespace TestAutomation.Test.Inicio
{
    [TestFixture]
    public class TestBasico
    {
        [Test]
        public void TestBasicWebPage()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize(); // sentencia para maximizar navegador
            driver.Url = "https://curso.testautomation.es"; //para navegar a la pj web que vamos a testear
            var normalLoadWeb = driver.FindElement(By.Id("NormalWeb"));// para ubicar por id el elemento de la pagina
            normalLoadWeb.Click();// para hacer click en el elemento.
        }
    }
}
