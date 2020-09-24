using Docker.DotNet.Models;
using MarsQA_1.Pages;
using TechTalk.SpecFlow;
using MarsQA_1.Helper;
using Driver = MarsQA_1.Helper.Driver;

namespace MarsQA_1.StepDefination
{
    [Binding]
    public sealed class Skills_Step
    {
        skillAdd_Page _skill = new skillAdd_Page();
        [Given(@"click in the Skills tab")]
        public void GivenClickInTheSkillsTab()
        {
            _skill.Find_Skill_tab();
        }

        [When(@"I click in the add new Skills")]
        public void WhenIClickInTheAddNewSkills()
        {
            _skill.Add_Record();
        }

        [Then(@"I am verify that Skills record add or not")]
        public void ThenIAmVerifyThatSkillsRecordAddOrNot()
        {
            _skill.Add();
        }

        //Edit the skills


        

        [When(@"I click in Edit Button of skill")]
        public void WhenIClickInEditButtonOfSkill()
        {
            _skill.Click_Edit_Button();
        }


        [When(@"I edit the Skills record and dispaly the alert message")]
        public void WhenIEditTheSkillsRecordAndDispalyTheAlertMessage()
        {
            _skill.Edit_Skills();
        }

        [Then(@"I am verify that Skills record is edit or not")]
        public void ThenIAmVerifyThatSkillsRecordIsEditOrNot()
        {
            _skill.Edit_Record();
        }

        //Delete skills

        [Given(@"I click in Delete Button for skills")]
        public void GivenIClickInDeleteButtonForSkills()
        {
            _skill.DeleteSkill();
        }

    }
}
