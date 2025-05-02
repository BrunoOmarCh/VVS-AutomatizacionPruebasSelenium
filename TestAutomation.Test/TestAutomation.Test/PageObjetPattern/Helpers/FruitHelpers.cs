using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomation.Test.PageObjetPattern.Models;
using TestAutomation.Test.PageObjetPattern.PageObject.HomePage;

namespace TestAutomation.Test.PageObjetPattern.Helpers
{
    public class FruitHelpers
    {
        // Convierte una lista de IWebElement en una lista de FruitWebElement.
        public static IList<FruitWebElement> Parse(IList<IWebElement> fruits)
        {
            return fruits.Select(fruit => new FruitWebElement(fruit)).ToList();
        }

        // Convierte una lista de FruitWebElement en una lista de FruitModel.
        public static IList<FruitModel> Parse(IList<FruitWebElement> fruits)
        {
            return fruits.Select(fruit => Parse(fruit)).ToList();
        }

    }
}
