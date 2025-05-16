using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Test.PageObjetPattern.PageObject.ContacUs
{
    public class ContactUsPageObject
    {
        //4.2.1 
        private IWebDriver driver;
        //pripiedades
        private IWebElement InputFieldContactTitle => driver.FindElement(By.Id("contactTitle"));
        private IWebElement InputFieldContactEmail => driver.FindElement(By.Id("contactEmail"));
        private SelectElement DropdownCategory => new SelectElement(driver.FindElement(By.Id("contactCategory")));
        private IWebElement InputFieldContactText => driver.FindElement(By.Id("contactText"));
        private IWebElement ButtonSubmit =>
        driver.FindElement(By.CssSelector("#contactForm button"));
        private IWebElement ButtonClose => driver.FindElement(By.Id("closeContactPopup"));

        //para los msg de error
        //4.3.2 
        private IWebElement TitleErrorMessage => driver.FindElement(By.Id("contactTitleError"));
        private IWebElement EmailErrorMessage => driver.FindElement(By.Id("contactEmailError"));
        private IWebElement TextErrorMessage => driver.FindElement(By.Id("contactTextError"));

        //definimos el constructor
        public ContactUsPageObject(IWebDriver driver)
        {
            this.driver = driver;
        }
        //4.3.1 
        public void ClickSumit() => ButtonSubmit.Click();

        //es un if compacto si existe error entonces el text caso contrario null
        //4.3.2 
        public string? GetDisplayedTitleErrorMessage() =>
        TitleErrorMessage.Displayed ? TitleErrorMessage.Text : null;

    }
}
