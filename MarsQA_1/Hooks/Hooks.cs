
using MarsQA_1.Pages;
using OpenQA.Selenium;
using BoDi;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using Docker.DotNet.Models;
using System;
using MarsQA_1.Helper;
using Driver = MarsQA_1.Helper.Driver;
using MarsQA_1.Helpers;
using System.Threading;

namespace MarsQA_1.Hooks
{
    [Binding]


    public class Hooks
    {


        [BeforeScenario]


        public void Setup()
        {
            //IWebDriver driver = new ChromeDriver();
            //Defining the browser
            Driver driver = new Driver();
            
            driver.Initialize();
           
            ExcelLibHelper.PopulateInCollection(@"D:\Internship_2020\MarsQA_1\MarsQA_1\SpecflowTests\Data\Mars.xlsx", "Credentials");

            Thread.Sleep(2000);
            Mars_Login _login = new Mars_Login();
            _login.ClickIn();
            _login.SignIn();

        }

        //}

          [AfterScenario]
        public void AfterScenario()
      {
        //    Driver.Close();
           Driver.driver.Quit();
        }


    }
   
}
