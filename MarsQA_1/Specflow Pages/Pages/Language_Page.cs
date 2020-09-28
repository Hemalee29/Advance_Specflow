using DocumentFormat.OpenXml.Drawing.Charts;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using StackExchange.Redis;
using System;
using System.Threading;
using MarsQA_1.Helper;


namespace MarsQA_1.Pages
{

    class Language_Page
    {

        public void tab()
        {
            Thread.Sleep(2000);
            //new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(50)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='row']//form[@class='ui form']//div[@class='ui top attached tabular menu']//a[text()='Languages']")));
            //click in Language tab
            Driver.driver.FindElement(By.XPath("//div[@class='row']//form[@class='ui form']//div[@class='ui top attached tabular menu']//a[text()='Languages']")).Click();
            

            //add new langugae
            Thread.Sleep(2000);
            Driver.driver.FindElement(By.XPath("//div[@data-tab='first']//div[@class='row']//thead/tr/th[@class='right aligned']//div[text()='Add New']")).Click();

            //Enter Language
            Thread.Sleep(2000);
             Driver.driver.FindElement(By.Name("name")).SendKeys("Hindi");
            
        }

       

        public void Addnew()
        {
            //Select dropdown
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")).Click();
            Driver.driver.FindElement(By.XPath("//option[text()='Fluent']")).Click();

        }

        public void Language_Validation()
        {
            //Add Language
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")).Click();

            //try
            //{
                new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")));

                IWebElement Hindi = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));

                
                if (Hindi.Text == "Hindi")
                {
                Assert.Pass("Language add succsesfully");
                //Console.WriteLine("Language add succsesfully");
                }
                else
                {
                    Assert.Fail("Language add not succsesfully");
                //Console.WriteLine("Language not add succsesfully");
            }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Validation is not performing" + e);
            //}



        }

        //Edit Language

        
        public void Editbutton()
        {
            //Edit button
            Thread.Sleep(2000);
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i")).Click();

        }

        public void EditLanguage()
        {

            //language.Click();
            Thread.Sleep(2000);
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input")).Click();

            //language clear;
            Thread.Sleep(2000);
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input")).Clear();

            //language new value add
            Thread.Sleep(2000);
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input")).SendKeys("British");


            //Select dropdown
            Thread.Sleep(2000);
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/div[2]/select")).Click();
            Driver.driver.FindElement(By.XPath("//option[text()='Conversational']")).Click();

            
        }

        public void EditRecord()
        {

            //click on the update button
            Thread.Sleep(2000);
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]")).Click();

            //try
            //{
            new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")));

            IWebElement British = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));


            if (British.Text == "British")
            {
                //Assert.Pass("Language Edit succsesfully");
                Console.WriteLine("Education Edit passed");
            }
            else
            {
                //Assert.Fail("Language Edit not succsesfully");
                Console.WriteLine("Education Edit failed");
            }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Validation is not performing" + e);
            //}




        }



        public void DeleteLangauge()
        {

            //Delete the Record
            //Thread.Sleep(2000);
            new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(50)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//td[text()='British']//parent::tr//following-sibling::span[@class='button']//i[@class='remove icon']")));
            Driver.driver.FindElement(By.XPath("//td[text()='British']//parent::tr//following-sibling::span[@class='button']//i[@class='remove icon']")).Click();

            Thread.Sleep(2000);
            //new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")));

            IWebElement British = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table"));


            if (British.Text != "British")
            {
                Assert.Pass("Language Delete succsesfully");
                //Console.WriteLine("passed");
            }
            else
            {
                Assert.Fail("Language Delete not succsesfully");
                //Console.WriteLine("failed");
            }


        }

    }
}

