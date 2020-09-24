Feature: Education
	Add,Edit,Delete(CRUD) for Education
	

@mytag
Scenario:1 Add new Education
	Given click in the Education tab
	When I add the new Education
	Then I am verify that Education is succsfully add or not 



@mytag
Scenario:2 Edit Education
	Given click in the Education tab
	When Click on the Edit button
	And I edit the Education record and dispaly the alert message
	Then I am verify that Education record is edit or not 




@mytag
Scenario:3 Delete Education
	Given click in the Education tab
	When Click on the Delete button
	