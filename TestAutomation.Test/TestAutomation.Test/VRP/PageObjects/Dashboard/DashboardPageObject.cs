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
    public class DashboardPageObject
    {
        private readonly IWebDriver driver;
        private readonly int timeoutMs = 10000;

        // Localizador “Flota”
        private By FlotaLink => By.CssSelector(".headerBox_link[href='/dashboard/flotas/vehiculos']");

        public DashboardPageObject(IWebDriver driver)
        {
            this.driver = driver;
        }

    }
}
