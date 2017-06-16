using Andrii_Denysov_FinalProject.Pages.Components;
using Andrii_Denysov_FinalProject.SeleniumElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrii_Denysov_FinalProject.Pages
{
    public class InboxPage : BasePage
    {
        private By _writeButtonLocator = By.XPath(".//div[text()='НАПИСАТЬ']");
        private By _inboxButtonLocator = By.XPath(".//a[contains(@title, 'Входящие')]");
        private By _lettersLocator = By.XPath(".//colgroup/..//tr");
        private By _notificationLocator = By.XPath(".//span[text()='Просмотреть сообщение']");
        public InboxPage (IWebDriver driver) : base (driver) { }

        public EmailForm EmailForm => new EmailForm(Driver);
        public WebElement WriteButton => new WebElement(Driver, _writeButtonLocator);
        public WebElement InboxButton => new WebElement(Driver, _inboxButtonLocator);
        public WebElement FirstLetter => new WebElement(Driver, _lettersLocator);
        public WebElement Notification => new WebElement(Driver, _notificationLocator);
    }
}
