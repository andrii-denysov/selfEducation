using Andrii_Denysov_FinalProject.SeleniumElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrii_Denysov_FinalProject.Pages
{
    public class OpenedEmailPage : BasePage
    {
        private By _senderLabelLocator = By.XPath(".//span[@class='go']");
        private By _subjectLabelLocator = By.XPath(".//table//h2");
        private By _mailBodyLocator = By.XPath(".//div[contains(@class,'a3s')]/div[@dir]");
        private By _deleteMessageButtonLocator = By.XPath("(.//div[contains(@class,'ar9')])[2]");
        public OpenedEmailPage(IWebDriver driver) : base(driver) { }

        public WebElement SenderLabel => new WebElement(Driver, _senderLabelLocator);
        public WebElement SubjectLabel => new WebElement(Driver, _subjectLabelLocator);
        public WebElement MailBody => new WebElement(Driver, _mailBodyLocator);
        public WebElement DeleteMessageButton => new WebElement(Driver, _deleteMessageButtonLocator);
    }
}
