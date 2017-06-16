using Andrii_Denysov_FinalProject.SeleniumElements;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrii_Denysov_FinalProject.Pages
{
    class LoginPage : BasePage
    {
        private By _loginInputLocator = By.Id("Email");
        private By _passwordInputLocator = By.Id("Passwd");
        private By _nextButtonLocator = By.Id("next");
        private By _stayInTheSystemCheckBoxLocator = By.Id("PersistentCookie");
        private By _loginButtonLocator = By.Id("signIn");
        public LoginPage(IWebDriver driver) : base(driver) { }

        public WebElement LoginInput => new WebElement(Driver, _loginInputLocator);
        public WebElement PasswordInput => new WebElement(Driver, _passwordInputLocator);
        public WebElement NextButton => new WebElement(Driver, _nextButtonLocator);
        public WebElement StayInTheSystemCheckBox => new WebElement(Driver, _stayInTheSystemCheckBoxLocator);
        public WebElement LoginButton => new WebElement(Driver, _loginButtonLocator);
    }
}
