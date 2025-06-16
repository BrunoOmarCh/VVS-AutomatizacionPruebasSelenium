using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomation.Test.PageObjetPattern;
using TestAutomation.Test.PageObjetPattern.Helpers;
using TestAutomation.Test.VRP.Helpers;
using TestAutomation.Test.VRP.PageObjects.Dashboard;
using TestAutomation.Test.VRP.PageObjects.Home;

namespace TestAutomation.Test.VRP
{
    public class VRPTests : TestBase
    {
    #pragma warning disable NUnit1032
        // LoginTests
        // 1) Click en "Ingresar"
        // 2) Rellenar
        // 3) Enviar
        // 4) Verificar redirección al dashboard
        [Test]
        public void LoginTests()
        {
            using var context = new UITestContextVRP();
            IWebDriver driver = context.Driver;

            // 1) Click en "Ingresar"
            var loginForm = new VRPHomePageObject(driver)
                                .ClickSubmitButton();

            // 2) Rellenar
            loginForm
                .EnterEmail("dereck.chochoca@gmail.com")
                .EnterPassword("dereck");
            // 3) Enviar
            loginForm.ClickLogin();

    }
}
