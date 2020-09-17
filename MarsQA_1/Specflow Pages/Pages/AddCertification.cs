using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MarsQA_1.Pages
{
    class AddCertification
    {
        public void AddCertificateDetail(IWebDriver driver)
        {
            //Find the Certificate tab
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//a[text()='Languages']")));
            driver.FindElement(By.XPath("//a[text()='Certifications']")).Click();

            //Find the Add new button
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//th[text()='Certificate']//parent::tr//following-sibling::th[@class='right aligned']//div[@class='ui teal button ']")).Click();

            //Enter Certificate
            Thread.Sleep(2000);
            driver.FindElement(By.Name("certificationName")).SendKeys("CISCO");
           

            //Certified From
            Thread.Sleep(2000);
             driver.FindElement(By.Name("certificationFrom")).SendKeys("India");
            

            //Select dropdown for Year
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select")).Click();
            driver.FindElement(By.XPath("//option[text()='2017']")).Click();

            //Add Detail
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]")).Click();

        }




        //Edit Certificate

        public void EditCertification(IWebDriver driver)
        {
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]/i")).Click();

            //language.Click();
            driver.FindElement(By.Name("certificationName")).Click();

            //language clear;
            driver.FindElement(By.Name("certificationName")).Clear();

            //language new value add
            driver.FindElement(By.Name("certificationName")).SendKeys("CISCO123");

            //FromClick();
            driver.FindElement(By.Name("certificationFrom")).Click();

            //From clear;
            driver.FindElement(By.Name("certificationFrom")).Clear();

            //From new value add
            driver.FindElement(By.Name("certificationFrom")).SendKeys("USA");

            //Select dropdown
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[3]/select")).Click();
            driver.FindElement(By.XPath("//option[text()='2019']")).Click();

            //click on the update button
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/span/input[1]")).Click();
        }

        public void DeleteCertficate(IWebDriver driver)
        {

            //Delete the Record
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//td[text()='CISCO123']//parent::tr//following-sibling::span[@class='button']//i[@class='remove icon']")));
            driver.FindElement(By.XPath("//td[text()='CISCO123']//parent::tr//following-sibling::span[@class='button']//i[@class='remove icon']")).Click();


        }

        }
    }
