using Andrii_Denysov_FinalProject.Entities;
using Andrii_Denysov_FinalProject.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrii_Denysov_FinalProject.Helpers
{
    public class LoginPageHelper : BaseHelper
    {
        private LoginPage _googleLoginPage;
        public LoginPageHelper(IWebDriver driver) : base(driver)
        {
            _googleLoginPage = new LoginPage(driver);
        }

        public void Login(User user)
        {
            _googleLoginPage.LoginInput.Text = user.Login;
            _googleLoginPage.NextButton.Click();
            _googleLoginPage.StayInTheSystemCheckBox.Click();
            _googleLoginPage.PasswordInput.Text = user.Password;
            _googleLoginPage.LoginButton.Click();
        }        
    }
}
