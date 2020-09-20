Feature: Education
	Add,Edit,Delete(CRUD) for Education
	

@mytag
Scenario: Add new Education
	Given click in the Education tab
	When I add the new Education
	Then I am verify that Education is succsfully add or not 



@mytag
Scenario: Edit Education
	Given Click on the Edit button
	When I edit the Education record and dispaly the alert message
	Then I am verify that Education record is edit or not 




@mytag
Scenario: Delete Education
	Given Click on the Delete button
	When Delete the record and display the alert message
	Then I am verify that Education record is Delete 