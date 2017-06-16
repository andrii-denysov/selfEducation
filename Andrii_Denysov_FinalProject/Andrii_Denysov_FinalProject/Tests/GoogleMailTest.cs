using Andrii_Denysov_FinalProject.Configuration;
using Andrii_Denysov_FinalProject.SeleniumElements;
using Andrii_Denysov_FinalProject.Entities;
using Andrii_Denysov_FinalProject.Helpers;
using Andrii_Denysov_FinalProject.Pages;
using Newtonsoft.Json;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Andrii_Denysov_FinalProject.Tests;
using RelevantCodes.ExtentReports;

namespace Andrii_Denysov_FinalProject.Test
{
    [TestFixture]
    public class GoogleMailTest : BaseTest
    {        
        protected GoogleSearchPageHelper GoogleSearchPageHelper;
        protected LoginPageHelper LoginPageHelper;
        protected InboxPageHelper InboxPageHelper;
        protected OpenedEmailPageHelper OpenedEmailPageHelper;        

        [SetUp]
        public void SetUp()
        {
            GoogleSearchPageHelper = new GoogleSearchPageHelper(Driver);
            LoginPageHelper = new LoginPageHelper(Driver);
            InboxPageHelper = new InboxPageHelper(Driver);
            OpenedEmailPageHelper = new OpenedEmailPageHelper(Driver);
            Test = Extent.StartTest("SendingMailToYourselfTest", "GoogleMailTest");
            ImgPath = Test.AddScreenCapture($@"{AppDomain.CurrentDomain.BaseDirectory}\");
            Test.Log(LogStatus.Info, "Components initialisation were successful");
        }
        
        [Test]
        [Description("GoogleMailTest")]
        public void SendingMailToYourselfTest ()
        {          
            Driver.Navigate().GoToUrl("https://www.google.com.ru/");
            Test.Log(LogStatus.Info, "Google page was successfully opened");
            GoogleSearchPageHelper.NavigateToLoginPage();
            LoginPageHelper.Login(TestConfiguration.User);
            Test.Log(LogStatus.Info, "Login was successful");
            GoogleSearchPageHelper.CreateNewEmail();
            InboxPageHelper.WriteEmail(TestConfiguration.TestData.To, TestConfiguration.TestData.Subject, TestConfiguration.TestData.MailText);
            Test.Log(LogStatus.Info, "Email was sended");
            InboxPageHelper.WatchMailsViaNotification();
            InboxPageHelper.OpenFirstLetter();
            Test.Log(LogStatus.Info, "Email was opened");
            Assert.That(OpenedEmailPageHelper.IsCorrectMessage(
                TestConfiguration.TestData.To,
                TestConfiguration.TestData.Subject,
                TestConfiguration.TestData.MailText));
            Test.Log(LogStatus.Info, "Recieved mail matches with sended mail");
        }

        [TearDown]
        public void TearDown ()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status.ToString() == "Passed")
            {
                Test.Log(LogStatus.Pass, "Test was successfylly passed");
            }
            else
            {
                Test.Log(LogStatus.Fail, "Test was failed");
            }
            OpenedEmailPageHelper.DeleteMessage();
        }
    }
}
