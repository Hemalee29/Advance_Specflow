using MarsQA_1.Hooks;
using MarsQA_1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using MarsQA_1.Helper;
//using Driver = MarsQA_1.Hooks.Driver;

namespace MarsQA_1.StepDefination
{
    [Binding]
    public sealed class Certifications_Step
    {
        AddCertification_Page _Certificate = new AddCertification_Page();
        
        [Given(@"click in the Certifications tab")]
        public void GivenClickInTheCertificationsTab()
        {
            _Certificate.Find_Certificate_Tab();
        }

        [When(@"I click in the add new Certifications")]
        public void WhenIClickInTheAddNewCertifications()
        {
            _Certificate.Add_New_Details();
        }

        [Then(@"I am verify that Certifications is succsfully add or not")]
        public void ThenIAmVerifyThatCertificationsIsSuccsfullyAddOrNot()
        {
            _Certificate.Add_Certificate();
        }


        //Edit certificate

        [Given(@"I click in Edit Button for certifications")]
        public void GivenIClickInEditButtonForCertifications()
        {
            _Certificate.Click_Edit_Button();
        }

        [When(@"I edit the Certificationsn record and dispaly the alert message")]
        public void WhenIEditTheCertificationsnRecordAndDispalyTheAlertMessage()
        {
            _Certificate.Edit_Certificate_Details();
        }

        [Then(@"I am verify that Certifications record is edit or not")]
        public void ThenIAmVerifyThatCertificationsRecordIsEditOrNot()
        {
            _Certificate.Add_Certificate_Details();
        }

        //Delete certificate

        [Given(@"I click in Delete Button for certificate")]
        public void GivenIClickInDeleteButtonForCertificate()
        {
            _Certificate.DeleteCertficate();
        }



    }
}
