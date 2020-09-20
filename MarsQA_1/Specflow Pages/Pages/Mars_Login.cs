//using MarsQA_1.Specflow_Pages.Helper;
using MarsQA_1.Specflow_Pages.Helper;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsQA_1.Pages
{
    public class Mars_Login
    {
        public void ClickIn(IWebDriver driver)
        {
            //Click on the Login Button

            IWebElement SignInButton = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
            SignInButton.Click();

        }
        public void SignIn(IWebDriver driver)
        { 
            //Enter Email Address


            IWebElement Email = driver.FindElement(By.Name("email"));

          Email.SendKeys(ExcelLibHelper.ReadData(2, "username"));
            
            //Email.SendKeys("infohemalipatel29@gmail.com");
           
            //Enter Password

            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys(ExcelLibHelper.ReadData(2, "password"));
            //Password.SendKeys("hemali@2910");

            //Click on Remember me
            IWebElement Remember = driver.FindElement(By.Name("rememberDetails"));
            Remember.Click();

            //Click on Login Button
            IWebElement LoginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            LoginButton.Click();
        
        
        }
    }
}
