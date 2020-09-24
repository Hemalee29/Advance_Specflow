//using MarsQA_1.Specflow_Pages.Helper;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using MarsQA_1.Helper;

namespace MarsQA_1.Helper
{
    public class Driver
    {
        //Initialize the browser
        public static IWebDriver driver;

        public void Initialize()
        {
            //Defining the browser
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://192.168.99.100:5000");

            //Maximise the window
            driver.Manage().Window.Maximize();
        }
    }
}




//        //Close the browser
//        public void Close()
//        {
//            driver.Quit();
//        }

//    }
//}
