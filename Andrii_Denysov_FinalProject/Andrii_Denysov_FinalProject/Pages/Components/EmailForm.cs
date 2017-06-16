using Andrii_Denysov_FinalProject.SeleniumElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrii_Denysov_FinalProject.Pages.Components
{
    public class EmailForm : BasePage
    {
        private By _recieverInputLocator = By.XPath(".//textarea[@aria-label='Кому']");
        private By _subjectInputLocator = By.XPath(".//input[@placeholder='Тема']");
        private By _mailBodyLocator = By.XPath(".//div[@aria-label='Тело письма']");
        private By _sendButtonLocator = By.XPath(".//div[text()='Отправить']");
        public EmailForm (IWebDriver driver) : base (driver) { }

        public WebElement RecieverInput => new WebElement(Driver, _recieverInputLocator);
        public WebElement SubjectInput => new WebElement(Driver, _subjectInputLocator);
        public WebElement MailBodyTextArea => new WebElement(Driver, _mailBodyLocator);
        public WebElement SendButton => new WebElement(Driver, _sendButtonLocator);
    }
}
