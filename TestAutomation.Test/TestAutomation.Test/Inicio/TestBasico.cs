using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace TestAutomation.Test.Inicio
{
    [TestFixture]
    public class TestBasico
    {
        [Test]
        public void TestBasicWebPage()
        {
            var driver = new ChromeDriver();
        }
    }
}
