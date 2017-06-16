using Andrii_Denysov_FinalProject.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrii_Denysov_FinalProject.Helpers
{
    public class OpenedEmailPageHelper : BaseHelper
    {
        OpenedEmailPage _openedEmailPage;
        public OpenedEmailPageHelper(IWebDriver driver) : base(driver)
        {
            _openedEmailPage = new OpenedEmailPage(driver);
        }

        public bool IsCorrectMessage(string sender, string subject, string mailText)
        {
            return _openedEmailPage.SenderLabel.Text.Contains(sender)
                && _openedEmailPage.SubjectLabel.Text.Equals(subject)
                && _openedEmailPage.MailBody.Text.Equals(mailText);
        }

        public void DeleteMessage() => _openedEmailPage.DeleteMessageButton.Click();
    }
}
