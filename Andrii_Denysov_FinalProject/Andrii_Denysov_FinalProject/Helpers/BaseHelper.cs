using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrii_Denysov_FinalProject.Helpers
{
    public abstract class BaseHelper
    {
        private IWebDriver _driver;
        protected BaseHelper (IWebDriver driver)
        {
            _driver = driver;
        }

        public void RefreshPage() => _driver.Navigate().Refresh();
    }
}
