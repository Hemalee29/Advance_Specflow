using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MarsQA_1.Pages
{
    class Education_Page
    {
        public void AddEducation(IWebDriver driver)
        {
            //Find the Skill
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//a[text()='Skills']")));
            driver.FindElement(By.XPath("//a[text()='Education']")).Click();

            //Find the Add new button
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//a[text()='Skills']")));
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div")).Click();

            //Enter College/University Name
            Thread.Sleep(2000);
            IWebElement Language = driver.FindElement(By.Name("instituteName"));
            Language.SendKeys("GIT");

            //Select Country of College/University
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select")).Click();
            driver.FindElement(By.XPath("//option[text()='Afghanistan']")).Click();

            //Select Title
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select")).Click();
            driver.FindElement(By.XPath("//option[text()='B.A']")).Click();

            //Enter Degree
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input")).SendKeys("Diploma");


            //Select yearOfGraduation
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select")).Click();
            driver.FindElement(By.XPath("//option[text()='2012']")).Click();


            //Add Education
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]")).Click();

        }

        //Edit Education
        public void EditEducation(IWebDriver driver)
        {
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i")).Click();

            //Education Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Name("instituteName")).Click();

            //Skill clear;
            Thread.Sleep(2000);
            driver.FindElement(By.Name("instituteName")).Clear();

            //skill new value add
            Thread.Sleep(2000);
            driver.FindElement(By.Name("instituteName")).SendKeys("AIT");


            //Select Education Country
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[2]/select")).Click();
            driver.FindElement(By.XPath("//option[text()='Angola']")).Click();

            //Select Education Title
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[1]/select")).Click();
            driver.FindElement(By.XPath("//option[text()='B.Sc']")).Click();

            //Education new value add
            Thread.Sleep(2000);
            driver.FindElement(By.Name("degree")).Clear();
            driver.FindElement(By.Name("degree")).SendKeys("Advance Diploma");

            //Select Education Year
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[3]/select")).Click();
            driver.FindElement(By.XPath("//option[text()='2017']")).Click();


            //click on the update button
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]")).Click();
        }





        public void DeleteEducation(IWebDriver driver)
        {

            //Delete the Record
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//td[text()='Angola']//parent::tr//following-sibling::span[@class='button']//i[@class='remove icon']")));
            driver.FindElement(By.XPath("//td[text()='Angola']//parent::tr//following-sibling::span[@class='button']//i[@class='remove icon']")).Click();




        }
    }
}
