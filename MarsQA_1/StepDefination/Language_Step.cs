using Docker.DotNet.Models;
using MarsQA_1.Hooks;
using MarsQA_1.Pages;
using TechTalk.SpecFlow;
using MarsQA_1.Helper;
using Driver = MarsQA_1.Helper.Driver;

namespace MarsQA_1.StepDefination
{
    [Binding]

   
    public sealed class Language_Step 

    {
        Language_Page _language = new Language_Page();

        [Given(@"click on the Language tab")]
        public void GivenClickOnTheLanguageTab()
        {
            
            _language.tab();
        }

        [When(@"I click on the add new language")]
        public void WhenIClickOnTheAddNewLanguage()
        {
            
            _language.Addnew();
        }

        [Then(@"I verify that language is successfully add or not")]
        public void ThenIVerifyThatLanguageIsSuccessfullyAddOrNot()
        {
            
            _language.Language_Validation();
        }


        //Edit language

        [Given(@"I click in Edit Button")]
        public void GivenIClickInEditButton()
        {
            
            _language.Editbutton();
        }

        [When(@"I edit the Language record and dispaly the alert message")]
        public void WhenIEditTheLanguageRecordAndDispalyTheAlertMessage()
        {
            
            _language.EditLanguage();
        }

        [Then(@"I am verify that language record is edit or not")]
        public void ThenIAmVerifyThatLanguageRecordIsEditOrNot()
        {
            
            _language.EditRecord();
        }


        //Delete record


        [Given(@"I click in Delete Button")]
        public void GivenIClickInDeleteButton()
        {
            
            _language.DeleteLangauge();
        }


    }
}
