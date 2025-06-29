﻿using OpenQA.Selenium;
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

        public AddVehiclePageObject EnterAnoFabricacion(int year)
        {
            var el = driver.FindElement(By.Id("año_fabricacion"));
            el.Clear(); el.SendKeys(year.ToString());
            return this;
        }
        public AddVehiclePageObject EnterPlaca(string placa)
        {
            var el = driver.FindElement(By.CssSelector("input[name='placa']"));
            el.Clear(); el.SendKeys(placa);
            return this;
        }
        public AddVehiclePageObject EnterMaxRecorrido(int m)
        {
            var el = driver.FindElement(By.Id("maximo_recorrido"));
            el.Clear(); el.SendKeys(m.ToString());
            return this;
        }
        public AddVehiclePageObject EnterMaxCapacidad(int m3)
        {
            var el = driver.FindElement(By.Id("maxima_capacidad"));
            el.Clear(); el.SendKeys(m3.ToString());
            return this;
        }
        public void ClickSave()
        {
            var save = driver.FindElement(By.CssSelector("button[type='submit']"));
            WaitHelper.WaitForCondition(() => save.Enabled, timeoutMs);
            save.Click();
        }
    }
}