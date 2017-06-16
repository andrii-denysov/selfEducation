using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrii_Denysov_FinalProject.SeleniumElements
{
    public class WebElement
    {
        private const int _secondsToWait = 30;
        private IWebElement _element;
        private By _locator;
        private WebDriverWait _wait;

        public string Text
        {
            get
            {
                if (!_element.Displayed)
                    WaitForElementAppear();
                return _element.Text;
            }
            set
            {
                if (!_element.Displayed)
                    WaitForElementAppear();
                if (!string.IsNullOrEmpty(value))
                    _element.SendKeys(value);
            }
        }
        public WebElement(IWebDriver driver, By locator)
        {
            _locator = locator;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(_secondsToWait));
            _wait.Until(ExpectedConditions.ElementIsVisible(_locator));
            _element = driver.FindElement(locator);            
        }

        public void Click()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(_locator));
            _element.Click();
        }

        public void WaitForElementAppear() => _wait.Until(ExpectedConditions.ElementIsVisible(_locator));
    }
}
