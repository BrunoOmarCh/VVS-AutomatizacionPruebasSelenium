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
    /// <summary>
    /// Page Object para el formulario "Agregar Vehículo".
    /// </summary>
    public class AddVehiclePageObject
    {
        private readonly IWebDriver driver;
        private readonly int timeoutMs = 10000;
        public AddVehiclePageObject(IWebDriver driver) => this.driver = driver;

        // ---------------- dropdown helper ----------------
        private AddVehiclePageObject SelectFirst(string labelFor)
        {
            // 1. abrir lista
            var btn = driver.FindElement(By.CssSelector($"label[for='{labelFor}'] + .custom-select .select-button"));
            btn.Click();

            // 2. esperar elementos visibles solo dentro de ESE dropdown
            WaitHelper.WaitForCondition(() =>
            {
                var container = btn.FindElement(By.XPath("./following-sibling::div[contains(@class,'select-content')]"));

                var items = container.FindElements(By.CssSelector(".select-item")).Where(e => e.Displayed).ToList();
                if (!items.Any()) return false;

                try
                {
                    items.First().Click();
                    return true;
                }
                catch
                {
                    return false;
                }
            }, timeoutMs);

            return this;
        }

        // ------------ métodos públicos fluidos -------------
        public AddVehiclePageObject SelectFirstMarca() => SelectFirst("marca");
        public AddVehiclePageObject SelectFirstModelo() => SelectFirst("modelo");
        public AddVehiclePageObject SelectFirstColor() => SelectFirst("color");
        public AddVehiclePageObject SelectFirstSoat() => SelectFirst("soat");
    }
}