Feature: Skills
	Add,Edit,Delete(CRUD) for Skills
	

@mytag
Scenario:1 Add new Skills
	Given click in the Skills tab 
	When I click in the add new Skills
	Then I am verify that Skills record add or not 



@mytag
Scenario:2 Edit Skills
	Given click in the Skills tab
	When I click in Edit Button of skill
	And I edit the Skills record and dispaly the alert message
	Then I am verify that Skills record is edit or not 




@mytag
Scenario:3 Delete Skills
	Given I click in Delete Button for skills
	