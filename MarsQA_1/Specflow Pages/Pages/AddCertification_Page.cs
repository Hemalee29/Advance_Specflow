using com.sun.tools.@internal.xjc;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using MarsQA_1.Helper;
using Driver = MarsQA_1.Helper.Driver;

namespace MarsQA_1.Pages
{
    class AddCertification_Page
    {
        public void Find_Certificate_Tab()
        {
            //Find the Certificate tab
            new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//a[text()='Languages']")));
            Driver.driver.FindElement(By.XPath("//a[text()='Certifications']")).Click();
        }

        public void Add_New_Details()
        {
            //Find the Add new button
            Thread.Sleep(2000);
            Driver.driver.FindElement(By.XPath("//th[text()='Certificate']//parent::tr//following-sibling::th[@class='right aligned']//div[@class='ui teal button ']")).Click();

            //Enter Certificate
            Thread.Sleep(2000);
            Driver.driver.FindElement(By.Name("certificationName")).SendKeys("CISCO");


            //Certified From
            Thread.Sleep(2000);
            Driver.driver.FindElement(By.Name("certificationFrom")).SendKeys("India");


            //Select dropdown for Year
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select")).Click();
            Driver.driver.FindElement(By.XPath("//option[text()='2017']")).Click();
        }


        public void Add_Certificate()
        {
            //Add Detail
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]")).Click();


        }



        ////Edit Certificate

        public void Click_Edit_Button()
        {
            Thread.Sleep(2000);
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]/i")).Click();
        }


        public void Edit_Certificate_Details()
        {
            //language.Click();
            Driver.driver.FindElement(By.Name("certificationName")).Click();

            //language clear;
            Driver.driver.FindElement(By.Name("certificationName")).Clear();

            //language new value add
            Driver.driver.FindElement(By.Name("certificationName")).SendKeys("CISCO123");

            //FromClick();
            Driver.driver.FindElement(By.Name("certificationFrom")).Click();

            //From clear;
            Driver.driver.FindElement(By.Name("certificationFrom")).Clear();

            //From new value add
            Driver.driver.FindElement(By.Name("certificationFrom")).SendKeys("USA");

            //Select dropdown
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[3]/select")).Click();
            Driver.driver.FindElement(By.XPath("//option[text()='2019']")).Click();
        }


        public void Add_Certificate_Details()
        {
            //click on the update button
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/span/input[1]")).Click();
        }

        public void DeleteCertficate()
        {

            //Delete the Record
            new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//td[text()='CISCO123']//parent::tr//following-sibling::span[@class='button']//i[@class='remove icon']")));
            Driver.driver.FindElement(By.XPath("//td[text()='CISCO123']//parent::tr//following-sibling::span[@class='button']//i[@class='remove icon']")).Click();


        }

    }
    }
