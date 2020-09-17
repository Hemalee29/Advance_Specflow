using MarsQA_1.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefination
{
    [Binding]

    public sealed class join

    {
        //Signup

        IWebDriver driver = new ChromeDriver();

        [Given(@"Navigate to Home Page and Click on the Join Button")]
        public void GivenNavigateToHomePageAndClickOnTheJoinButton()
        {
            HomePage _home = new HomePage();
            _home.OpenHomePage(driver);
            Mars_SignUp _Signup = new Mars_SignUp();
            _Signup.ClickOnJoin(driver);
        }

        [Then(@"I shold be able to fill all the details in registration page")]
        public void ThenISholdBeAbleToFillAllTheDetailsInRegistrationPage()
        {

            Mars_SignUp _Signup = new Mars_SignUp();
            _Signup.EnterValidData(driver);

        }

        [Then(@"I should be able to signup succesfully")]
        public void ThenIShouldBeAbleToSignupSuccesfully()
        {
            Mars_SignUp _Signup = new Mars_SignUp();
            _Signup.ClickMeTORegister(driver);
        }

        //LoginPage

        [Given(@"Navigate to HomePage")]
        public void GivenNavigateToHomePage()
        {
            HomePage _home = new HomePage();
            _home.OpenHomePage(driver);
        }

        [Then(@"I should be able to login succesfully with valid creadential\.")]
        public void ThenIShouldBeAbleToLoginSuccesfullyWithValidCreadential_()
        {
            Mars_Login _login = new Mars_Login();
            _login.SignIn(driver);
        }


        //Add Profile Details

        [Given(@"Navigate to Home Page and Click on the Signin button")]
        public void NavigatetoHomePageandClickontheSigninbutton()
        {
            HomePage _home = new HomePage();
            _home.OpenHomePage(driver);

            Mars_Login _login = new Mars_Login();
            _login.SignIn(driver);

        }



        [Then(@"I add the New Langauge")]
        public void ThenIAddTheNewLangauge()
        {
            
            AddProfileDetails _profile = new AddProfileDetails();
            _profile.AddLangauge(driver);
        }


        //Edit the Language

        [Then(@"I edit the Langauge")]
        public void ThenIEditTheLangauge()
        {
            AddProfileDetails _profile = new AddProfileDetails();
            _profile.EditLangauge(driver);
        }

        //Delete the Language

        [Then(@"I Delete the Language")]
        public void ThenIDeleteTheLanguage()
        {
            AddProfileDetails _profile = new AddProfileDetails();
            _profile.DeleteLangauge(driver);
        }


        //Skill




        [Then(@"I add the New Skill")]
        public void ThenIAddTheNewSkill()
        {
            skillAdd _skill = new skillAdd();
            _skill.AddSkill(driver);
        }

        [Then(@"I edit the Skill")]
        public void ThenIEditTheSkill()
        {
            skillAdd _skill = new skillAdd();
            _skill.Editskill(driver);
        }

        [Then(@"I Delete the Skill")]
        public void ThenIDeleteTheSkill()
        {
            skillAdd _skill = new skillAdd();
            _skill.DeleteSkill(driver);
        }

        //Add the Education

        [Then(@"I add the New Education")]
        public void ThenIAddTheNewEducation()
        {
            Education _Edu = new Education();
            _Edu.AddEducation(driver);
        }

        [Then(@"I Edit the Education")]
        public void ThenIEditTheEducation()
        {
            Education _Edu = new Education();
            _Edu.EditEducation(driver);
        }

        [Then(@"I Delete the Education")]
        public void ThenIDeleteTheEducation()
        {
            Education _Edu = new Education();
            _Edu.DeleteEducation(driver);
        }



        //Certificate Details

        [Then(@"I add the Certification Details")]
        public void ThenIAddTheCertificationDetails()
        {

            AddCertification _certificate = new AddCertification();
            _certificate.AddCertificateDetail(driver);

        }

        [Then(@"I Edit Certification Details")]
        public void ThenIEditCertificationDetails()
        {
            AddCertification _certificate = new AddCertification();
            _certificate.EditCertification(driver);
        }

        [Then(@"I Delete Certification Details")]
        public void ThenIDeleteCertificationDetails()
        {
            AddCertification _certificate = new AddCertification();
            _certificate.DeleteCertficate(driver);
        }


    }
}
