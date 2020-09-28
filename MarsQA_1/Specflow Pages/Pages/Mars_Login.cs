
using com.sun.tools.javac.util;
using Docker.DotNet.Models;
using MarsQA_1.Helpers;
using MongoDB.Driver.Core.Authentication;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using sun.security.util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Assert = NUnit.Framework.Assert;
using Driver = MarsQA_1.Helper.Driver;

namespace MarsQA_1.Pages
{
    public class Mars_Login
    {
        public string username { get; private set; }

        public void ClickIn()
        {

            //Click on the Login Button

            new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='home']/div/div/div[1]/div/a")));
            IWebElement Click = Driver.driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
            Click.Click();
            //Driver.driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a")).Click();

        }

        

        public void SignIn()
        {
            //Enter Email Address

            Thread.Sleep(2000);
            IWebElement username = Driver.driver.FindElement(By.Name("email"));

            username.SendKeys(ExcelLibHelper.ReadData(2, "username"));

            //Email.SendKeys("infohemalipatel29@gmail.com");

            //Enter Password
            Thread.Sleep(2000);
            IWebElement Password = Driver.driver.FindElement(By.Name("password"));
            Password.SendKeys(ExcelLibHelper.ReadData(2, "password"));
            //Password.SendKeys("hemali@2910");

            //Click on Remember me
            Thread.Sleep(2000);
            IWebElement Remember = Driver.driver.FindElement(By.Name("rememberDetails"));
            Remember.Click();

            //Click on Login Button
            Thread.Sleep(2000);
            IWebElement LoginButton = Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            LoginButton.Click();



            //try
            //{
            //    new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='ui compact menu']//span[text()='hemalee']")));

            //    IWebElement HeyHemalee = Driver.driver.FindElement(By.XPath("//div[@class='ui compact menu']//span[text()='hemalee']"));

            //    Assert.Pass(HeyHemalee.Text, Is.EqualTo("Hi hemalee"));
            //    if (HeyHemalee.Text == "Hi hemalee")
            //    {
            //        Assert.Pass("Login success");
            //    }
            //    else
            //    {
            //        Assert.Fail("Login fail");
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Validation is not performing" + e);
            //}



        }

    }


       
    }

