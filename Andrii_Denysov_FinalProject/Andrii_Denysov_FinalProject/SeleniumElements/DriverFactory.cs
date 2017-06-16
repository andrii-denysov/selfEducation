using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrii_Denysov_FinalProject.SeleniumElements
{
    public static class DriverFactory
    {
        private const string FirefoxDriver = "FIREFOX";
        private const string ChromeDriver = "CHROME";

        private static IWebDriver _driverInstance;

        public static IWebDriver GetDriver(string driverName)
        {
            switch (driverName.ToUpper())
            {
                case FirefoxDriver:
                    {
                        if (_driverInstance != null) { return _driverInstance; }
                        _driverInstance = new FirefoxDriver();
                        _driverInstance.Manage().Window.Maximize();
                        return _driverInstance;
                    }
                case ChromeDriver:
                    {
                        if (_driverInstance != null) { return _driverInstance; }
                        _driverInstance = new ChromeDriver();
                        _driverInstance.Manage().Window.Maximize();
                        return _driverInstance;
                    }
                default:
                    {
                        throw new WebDriverException();
                    }
            }
        }
    }
}
