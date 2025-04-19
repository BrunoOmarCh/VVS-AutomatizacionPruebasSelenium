using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Test.Selectores
{
    public class SelectoresTest_First
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


            // Opción 1: Usar FindElements para obtener todos los elementos con ID 'myld'
            // El índice [1] permite acceder al segundo elemento (por orden en el DOM)
            driver.FindElements(By.Id("myId"))[1].Text.Should().Be("Element 3");
            // Opción 2: Buscar dentro de una sección específica usando Name
            // Encuentra la sección 'elements' y luego ubica el ID 'myld' dentro de ella
            var elementsSecction = driver.FindElement(By.Name("elements"));
            elementsSecction.FindElement(By.Id("myId")).Text.Should().Be("Element 3");
            // Opcion 3: usando diectamente el selector de CSS.
            driver.FindElement(By.CssSelector("[name='elements'] [id='myId']")).Text.Should().Be("Element 3");

            // para el elemnet 4, lo buscaremos por nombre
            driver.FindElement(By.Name("myName")).Text.Should().Be("Element 4");

            //para el element 5, por CSS
            driver.FindElement(By.CssSelector("div [style = 'color:magenta']")).Text.Should().Be("Element 5");
            // para element 5 usando Xpath: esto es arriesgado pues depende de como se escriba el texto.
            driver.FindElement(By.XPath("//*[contains(text(), 'Element 5')]")).Text.Should().Be("Element 5");

            //para ubicar el element 6 por CSS.
            // CASO ESPECIAL: Element 6
            // Este elemento usa un atributo personalizado llamado 'autotestid="Element6"'
            // Este tipo de atributos son útiles cuando:
            //  - No hay identificadores únicos
            //  - Los ID son generados de forma aleatoria
            //  - El HTML es complejo
            // En estos casos, es importante hablar con los desarrolladores para que al menos:
            //  - Las secciones (div) tengan identificadores únicos y estables
            // Esto permite mejorar la mantenibilidad de los tests automatizados.
            driver.FindElement(By.CssSelector("[autotestid= 'Element6']")).Text.Should().Be("Element 6");

            // para ubicar Element 7 y 8 
            // CASO ESPECIAL: Element 7 y Element 8
            // Estos elementos no tienen atributos útiles como ID, clase o nombre.
            // Pero ambos están ubicados DENTRO del div con name="elements"
            // Solución:
            //  - Obtener todos los <div> dentro de la sección 'elements'
            //  - Seleccionar por posición dentro de esa lista
            // Nota: El índice comienza en 0, por lo tanto [5] = 6to elemento, [6] = 7mo elemento.
            var divElementsSection = driver.FindElements(By.CssSelector("[name='elements'] div"));// para obtener la lista de div
            divElementsSection[5].Text.Should().Be("Element 7");// es 5 pues la lista inicia en 0

            divElementsSection[6].Text.Should().Be("Element 8");

        }
    }
}
