using Andrii_Denysov_FinalProject.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrii_Denysov_FinalProject.Helpers
{
    public class InboxPageHelper : BaseHelper
    {
        private InboxPage _inboxPage;
        public InboxPageHelper(IWebDriver driver) : base(driver)
        {
            _inboxPage = new InboxPage(driver);
        }

        public void WriteEmail (string reciever, string subject, string mailText)
        {
            _inboxPage.WriteButton.Click();
            _inboxPage.EmailForm.RecieverInput.WaitForElementAppear();
            _inboxPage.EmailForm.RecieverInput.Text = reciever;
            _inboxPage.EmailForm.SubjectInput.Text = subject;
            _inboxPage.EmailForm.MailBodyTextArea.Text = mailText;
            _inboxPage.EmailForm.SendButton.Click();
            _inboxPage.InboxButton.Click();
        }

        public void OpenFirstLetter() => _inboxPage.FirstLetter.Click();

        public void WatchMailsViaNotification() => _inboxPage.Notification.Click();
    }
}
