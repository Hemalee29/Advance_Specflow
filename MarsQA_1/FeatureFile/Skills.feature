Feature: Skills
	Add,Edit,Delete(CRUD) for Skills
	

@mytag
Scenario: Add new Skills
	Given Navigate to Home Page and Click on the Signin button
	And  click in the Skills tab
	When I click in the add new Skills
	Then I am verify that Skills is succsfully add or not 



@mytag
Scenario: Edit Skills
	Given Navigate to Home Page and Click on the Signin button
	And  I click in Edit Button
	When I edit the Skills record and dispaly the alert message
	Then I am verify that Skills record is edit or not 




@mytag
Scenario: Delete Skills
	Given Navigate to Home Page and Click on the Signin button
	And  I click in Delete Button
	When Delete the record and display the alert message
	Then I am verify that Skills record is Delete 