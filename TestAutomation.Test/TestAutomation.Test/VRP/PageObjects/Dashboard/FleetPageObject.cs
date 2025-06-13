using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomation.Test.PageObjetPattern.Helpers;
using TestAutomation.Test.PageObjetPattern.Models;

namespace TestAutomation.Test.VRP.PageObjects.Dashboard
{
    public class FleetPageObject
    {
        private readonly IWebDriver driver;
        private readonly int timeoutMs = 10000;

        // Selector más específico dentro de panelCRUD_options
        private By AddVehicleBtn =>
            By.XPath("//button[./div/p[normalize-space()='Agregar Vehículo'] or normalize-space()='Agregar Vehículo']");

        public FleetPageObject(IWebDriver driver)
        {
            this.driver = driver;
        }

        /// <summary>
        /// Hace click en "Agregar Vehículo" y devuelve el formulario asociado.
        /// </summary>

    }
}
