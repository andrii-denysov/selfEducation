using Andrii_Denysov_FinalProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrii_Denysov_FinalProject.Configuration
{
    public class TestConfiguration
    {
        public User User { get; set; }
        public BrowserConfiguration BrowserConfiguration {get; set;}
        public TestData TestData { get; set; }
    }

    public class BrowserConfiguration
    {
        public string BrowserName { get; set; }
    }

    public class TestData
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string MailText { get; set; }
    }
}
