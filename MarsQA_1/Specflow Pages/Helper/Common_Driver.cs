using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsQA_1.Helper
{
    class Common_Driver
    {
        public IWebDriver driver;


        [OneTimeSetUp]
        public void _driver()
        {
            driver = new ChromeDriver();        
        }
    }
}
