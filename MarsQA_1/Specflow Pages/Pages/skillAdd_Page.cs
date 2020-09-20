using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MarsQA_1.Pages
{
    class skillAdd_Page
    {


        

            public void AddSkill(IWebDriver driver)
            {
                //Find the Skill
                new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//a[text()='Skills']")));
                driver.FindElement(By.XPath("//a[text()='Skills']")).Click();

                //Find the Add new button
                new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//a[text()='Skills']")));
                driver.FindElement(By.XPath("//th[text()='Skill']//parent::tr//following-sibling::th[@class='right aligned']//div[@class='ui teal button']")).Click();

                //Enter Skill
                Thread.Sleep(2000);
                IWebElement Language = driver.FindElement(By.Name("name"));
                Language.SendKeys("Painiting");

                //Select dropdown
                driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select")).Click();
                driver.FindElement(By.XPath("//option[text()='Beginner']")).Click();

                //Add Skill
                driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")).Click();

            }

        //Edit skill
        public void Editskill(IWebDriver driver)
        {
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i")).Click();

            //Skill.Click();
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input")).Click();

            //Skill clear;
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input")).Clear();

            //skill new value add
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input")).SendKeys("Creativity");


            //Select dropdown
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select")).Click();
            driver.FindElement(By.XPath("//option[text()='Intermediate']")).Click();

            //click on the update button
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]")).Click();
        }





        public void DeleteSkill(IWebDriver driver)
        {

            //Delete the Record
            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//td[text()='Creativity']//parent::tr//following-sibling::span[@class='button']//i[@class='remove icon']")));
            driver.FindElement(By.XPath("//td[text()='Creativity']//parent::tr//following-sibling::span[@class='button']//i[@class='remove icon']")).Click();

        }






        }
    }

