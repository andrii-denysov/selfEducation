using Andrii_Denysov_FinalProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrii_Denysov_FinalProject.Helpers
{
    public class GoogleSearchPageHelper : BaseHelper
    {
        private GoogleSearchPage _googleSearchPage;
        public GoogleSearchPageHelper (IWebDriver driver) : base(driver)
        {
            _googleSearchPage = new GoogleSearchPage(driver);            
        }

        public void NavigateToLoginPage() => _googleSearchPage.LoginButton.Click();

        public void CreateNewEmail() =>_googleSearchPage.MailButton.Click();
    }
}
