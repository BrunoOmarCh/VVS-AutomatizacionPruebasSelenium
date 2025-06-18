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

            // 4) Verificar redirección al dashboard
            WaitHelper.WaitForCondition(
                () => driver.Url.Contains("dashboard"),
                TestBase.TestSettings.WaitTimeout * 10000
            );

            Assert.IsTrue(
                driver.Url.Contains("dashboard"),
                $"Se esperaba 'dashboard' en la URL tras login, pero se obtuvo: {driver.Url}"
            );
        }
        [Test]
        public void CreateTestVehicles()
        {
            using var context = new UITestContextVRP();
            var driver = context.Driver;

            new VRPHomePageObject(driver)
                .ClickSubmitButton()
                .EnterEmail("dereck.chochoca@gmail.com")
                .EnterPassword("dereck")
                .ClickLogin();

            var addForm = new DashboardPageObject(driver)
                              .ClickFlota()          // abre módulo
                              .ClickAddVehicle();    // abre formulario

            addForm
                .SelectFirstMarca()
                .SelectFirstModelo()
                .EnterAnoFabricacion(2020)
                .SelectFirstColor()
                .EnterPlaca("ALF-648")
                .SelectFirstSoat()
                .EnterMaxRecorrido(10000)
                .EnterMaxCapacidad(300)
                .ClickSave();

            WaitHelper.WaitForCondition(
                () => driver.Url.Contains("/dashboard/flotas/vehiculos"),
                TestSettings.WaitTimeout * 1000
            );
        }
    }
}
