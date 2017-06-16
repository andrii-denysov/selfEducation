using Andrii_Denysov_FinalProject.Configuration;
using Andrii_Denysov_FinalProject.SeleniumElements;
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrii_Denysov_FinalProject.Tests
{
    public class BaseTest
    {
        protected IWebDriver Driver;
        protected static readonly TestConfiguration TestConfiguration =
            SimpleConfig.Configuration.Load<TestConfiguration>();
        protected ExtentReports Extent;
        protected ExtentTest Test;
        protected string ImgPath;

        [SetUp]
        protected void SetUp()
        {
            Driver = DriverFactory.GetDriver(TestConfiguration.BrowserConfiguration.BrowserName);
            Extent = new ExtentReports($@"{AppDomain.CurrentDomain.BaseDirectory}\Extent.Net.html", true);                      
        }

        [TearDown]
        protected void TearDown()
        {
            Extent.EndTest(Test);
            Extent.Flush();
            Driver.Close();
        }
    }
}
