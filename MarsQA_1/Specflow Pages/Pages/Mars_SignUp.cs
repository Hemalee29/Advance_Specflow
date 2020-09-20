using Docker.DotNet.Models;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

using Driver = Docker.DotNet.Models.Driver;
//using MarsQA_1.Specflow_Pages.Helper;

namespace MarsQA_1.Pages
{
    class Mars_SignUp

    {


        public void ClickOnJoin(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 20));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='home']/div/div/div[1]/div/button")));
            IWebElement JoinButton = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/button"));
            JoinButton.Click();
        }

    public void EnterValidData(IWebDriver driver)
        {
            //Enter First name

            IWebElement Firstname = driver.FindElement(By.Name("firstName"));
            Firstname.SendKeys("hemali");

            //Enter Last name
            IWebElement Lastname = driver.FindElement(By.Name("lastName"));
            Lastname.SendKeys("Patel");

            //Enter Email Address
            IWebElement Email = driver.FindElement(By.Name("email"));
            //Email.SendKeys(ExcelLibHelper.ReadData(2, "username"));

            Email.SendKeys("infohemalipatel29@gmail.com");

            //Enter Password
            IWebElement Password = driver.FindElement(By.Name("password"));
            //Password.SendKeys(ExcelLibHelper.ReadData(2, "password"));
            Password.SendKeys("hemali@2910");

            //Enter Confirm Password
            IWebElement CPassword = driver.FindElement(By.Name("confirmPassword"));
            CPassword.SendKeys("hemali@2910");
            Console.WriteLine(CPassword);

            //Term and condition cheakbox
            IWebElement Cheakbox = driver.FindElement(By.Name("terms"));
            Cheakbox.Click();

        }

        //internal void ClickMeTORegister()
        //{
        //    throw new NotImplementedException();
        //}

        //internal void EnterValidData()
        //{
        //    throw new NotImplementedException();
        //}

        //internal void ClickOnJoin()
        //{
        //    throw new NotImplementedException();
        //}

        public void ClickMeTORegister(IWebDriver driver)

            {
            //Click on Join Button

            IWebElement JoinButton = driver.FindElement(By.Id("submit-btn"));
            JoinButton.Click();
            Thread.Sleep(1000);
            driver.Close();


            }






        }


    }   

