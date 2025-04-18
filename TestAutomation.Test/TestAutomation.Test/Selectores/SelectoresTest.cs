using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using static System.Collections.Specialized.BitVector32;

namespace TestAutomation.Test.Selectores
{
    public class SelectoresTest
    {
        #pragma warning disable NUnit1032
        IWebDriver driver;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.Url = "https://curso.testautomation.es";
        }
        [TearDown]
        public void TearDownTest()
        {
            driver.Close();
        }
        [Test]
        public void GetEachOfTheElements()
        {
            // Navega a la sección 'SelectorsWeb' de la página
            driver.FindElement(By.Id("SelectorsWeb")).Click();
            // En la nueva página, verifica que el texto del primer elemento sea 'Element 1'
            // Se usa ID duplicado, pero aún es posible ubicarlo directamente
            driver.FindElement(By.Id("myId")).Text.Should().Be("Element 1");

            // Verifica el texto del segundo elemento mediante su clase
            driver.FindElement(By.ClassName("className")).Text.Should().Be("Element 2");

            // ✅ Opción 1: Usar FindElements para obtener todos los elementos con ID 'myld'
            // El índice [1] permite acceder al segundo elemento (por orden en el DOM)
            driver.FindElements(By.Id("myld"))[1].Text.Should().Be("Element 3");

            // ✅ Opción 2: Buscar dentro de una sección específica usando Name
            // Encuentra la sección 'elements' y luego ubica el ID 'myld' dentro de ella
            var elementsSecction = driver.FindElement(By.Name("elements"));
            elementsSecction.FindElement(By.Id("myld")).Text.Should().Be("Element 3"); 
        }
    }
}



