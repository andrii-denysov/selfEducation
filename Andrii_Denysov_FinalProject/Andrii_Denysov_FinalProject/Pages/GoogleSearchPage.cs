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
    public class GoogleSearchPage : BasePage
    {
        private By _loginButtonLocator = By.XPath(".//a[text()='Войти']");
        private By _mailLocator = By.XPath(".//a[text()='Почта']");
        public GoogleSearchPage (IWebDriver driver) : base(driver) { }

        public WebElement LoginButton => new WebElement(Driver, _loginButtonLocator);
        public WebElement MailButton => new WebElement(Driver, _mailLocator);
    }
}
