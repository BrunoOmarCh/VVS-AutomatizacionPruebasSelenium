using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Test.Frame
{
    public class FrameTests
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
            driver.Quit();
        }
        [Test]
        public void FrameTest()
        {
            //driver.FindElement(By.Id("DifferentFrames"));
            //var webElementLeft = driver.FindElements(By.CssSelector("h2"));
            //Error: inspecciona la pagina 2 vera que este h2 se encuentra}
            // dentro de iframe.que asu vez tiene un document
            //Entonces debemos cambiar, primero decirle que vaya
            //iframe id=mainframe y después al iframe id = displayFrame.


            driver.FindElement(By.Id("DifferentFrames")).Click(); //hace el click en primera pagina y va a la segunda
            driver.FindElement(By.CssSelector("button")).Click();// hace click en boton de la segunda pagina.se muestran los dos iframe


        }

    }
}
