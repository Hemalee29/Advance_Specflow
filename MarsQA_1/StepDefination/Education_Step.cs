using MarsQA_1.Hooks;
using MarsQA_1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using MarsQA_1.Helper;


namespace MarsQA_1.StepDefination
{
    [Binding]
    public sealed class Education_Step
    {
        Education_Page _Education = new Education_Page();


        [Given(@"click in the Education tab")]
        public void GivenClickInTheEducationTab()
        {
            _Education.Education_tab();
        }

        [When(@"I add the new Education")]
        public void WhenIAddTheNewEducation()
        {
            _Education.Education_Detail_Add();
        }

        [Then(@"I am verify that Education is succsfully add or not")]
        public void ThenIAmVerifyThatEducationIsSuccsfullyAddOrNot()
        {
            _Education.Education_Add();
        }

        //Edit Education



        [When(@"Click on the Edit button")]
        public void WhenClickOnTheEditButton()
        {
            _Education.Edit_Button();
        }

        [When(@"I edit the Education record and dispaly the alert message")]
        public void WhenIEditTheEducationRecordAndDispalyTheAlertMessage()
        {
            _Education.Edit_Record();
        }

        [Then(@"I am verify that Education record is edit or not")]
        public void ThenIAmVerifyThatEducationRecordIsEditOrNot()
        {
            _Education.Edit_Record_Update();
        }


        //Delete record

        [When(@"Click on the Delete button")]
        public void WhenClickOnTheDeleteButton()
        {
            _Education.DeleteEducation();
        }


        

    }
}
