
//using MarsQA_1.Helper;
using MarsQA_1.Pages;
//using MarsQA_1.Specflow_Pages.Helper;
//using MarsQA_1.Specflow_Pages.Helper;
using OpenQA.Selenium;
using BoDi;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TechTalk.SpecFlow;
using MarsQA_1.Specflow_Pages.Helper;

namespace MarsQA_1.Hooks
{
    [Binding]


    public class Hooks
    {
        //public object LogStatus { get; private set; }


        private IWebDriver driver;
       // Mars_Login _login = new Mars_Login();


        [BeforeScenario]

        
        public void Setup()
        {
            //IWebDriver driver = new ChromeDriver();
            //Defining the browser
            getDriver();
            ExcelLibHelper.PopulateInCollection(@"MarsQA_1\MarsQA_1\SpecflowTests\Data\Mars.xlsx", "Credentials");

            Mars_Login _login = new Mars_Login();
            _login.ClickIn(driver);
            _login.SignIn(driver);




        }




        //}

        //    [AfterScenario]
        //public void TearDown(IWebDriver driver)
        //{

        //    //// Screenshot
        //    //string img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
        //    //test.Log(LogStatus.Info, "Snapshot below: " + test.AddScreenCaptureFromPath(img));
        //    ////Close the browser
        //    //Close();

        //    //// end test. (Reports)
        //    //CommonMethods.Extent.EndTest(test);

        //    // calling Flush writes everything to the log file (Reports)
        //    //object p = CommonMethods.Extent.Flush();
        //    driver.Close();


        //}

        public void getDriver()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://192.168.99.100:5000");
            driver.Manage().Window.Maximize();

            //Maximise the window
            driver.Manage().Window.Maximize();
            
            ////call the SignIn class
            //Home_Page _home = new Home_Page();
            //_home.OpenHomePage(driver);
        }

    }
}