using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using MarsQA_1.Helper;


namespace MarsQA_1.Pages
{
    class skillAdd_Page
    {

        public void Find_Skill_tab()
        {
            //Find the Skill tab
            new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//a[text()='Skills']")));
            Driver.driver.FindElement(By.XPath("//a[text()='Skills']")).Click();
        }

        

        public void Add_Record()
        {
            //Find the Add new button
            new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//a[text()='Skills']")));
            Driver.driver.FindElement(By.XPath("//th[text()='Skill']//parent::tr//following-sibling::th[@class='right aligned']//div[@class='ui teal button']")).Click();

            //Enter Skill
            Thread.Sleep(2000);
            IWebElement Language = Driver.driver.FindElement(By.Name("name"));
            Language.SendKeys("Painiting");

            //Select dropdown
            Thread.Sleep(2000);
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select")).Click();
            Driver.driver.FindElement(By.XPath("//option[text()='Beginner']")).Click();
        }

        public void Add()
        {

            //Add Skill
            Thread.Sleep(5000);
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")).Click();

        }


        //Edit skill
        
        public void Click_Edit_Button()
        {
            Thread.Sleep(5000);
            //new WebDriverWait(driver, TimeSpan.FromSeconds(50)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i")));
            //driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i")).Click();
            Driver.driver.FindElement(By.XPath("//td[text()='Painiting']//parent::tr//following-sibling::td[@class='right aligned']//span[@class='button']//i[@class='outline write icon']")).Click();
        }

        public void Edit_Skills()
        {
            //Skill.Click();
            Thread.Sleep(2000);
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input")).Click();

            //Skill clear;
            Thread.Sleep(2000);
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input")).Clear();

            //skill new value add
            Thread.Sleep(2000);
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input")).SendKeys("Creativity");


            //Select dropdown
            Thread.Sleep(2000);
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select")).Click();
            Driver.driver.FindElement(By.XPath("//option[text()='Intermediate']")).Click();

        }

        public void Edit_Record()
        {

            //click on the update button
            Thread.Sleep(2000);
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]")).Click();
        }



        public void DeleteSkill()
        {

            //Delete the Record
            Thread.Sleep(2000);
            //new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//td[text()='Creativity']//parent::tr//following-sibling::span[@class='button']//i[@class='remove icon']")));
            Driver.driver.FindElement(By.XPath("//td[text()='Creativity']//parent::tr//following-sibling::span[@class='button']//i[@class='remove icon']")).Click();

        }

    }
    }

