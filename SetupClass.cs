using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestPages
{
    [SetUpFixture]
    internal class SetupClass
    {
        IWebDriver driver;


        [OneTimeSetUp]
        public void Setup()
        {
            driver = BrowserDriver.Create();
        }
    }
}
