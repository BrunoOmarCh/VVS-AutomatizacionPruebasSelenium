using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomation.Test.PageObjetPattern.Helpers;

namespace TestAutomation.Test.VRP.PageObjects.Login
{
    public class LoginPageObject
    {
        /// Formulario de login de RoadMap Pro.

        private readonly IWebDriver driver;
        private readonly int timeoutMs = 10000;

        private By EmailInput => By.CssSelector(".formBox_input input[type='email']");
        private By PasswordInput => By.CssSelector(".formBox_input input[type='password']");
        private By LoginButton => By.CssSelector(".formBox_button");

        public LoginPageObject(IWebDriver driver)
        {
            this.driver = driver;
        }

    }
}
