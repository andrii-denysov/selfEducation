using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrii_Denysov_FinalProject.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver Driver;        
        protected BasePage (IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);            
        }        
    }
}
