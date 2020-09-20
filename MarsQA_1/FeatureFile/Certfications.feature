Feature: Certifications
	Add,Edit,Delete(CRUD) for Certifications
	

@mytag
Scenario: Add new Certifications
	Given Navigate to Home Page and Click on the Signin button
	And  click in the Certifications tab
	When I click in the add new Certifications
	Then I am verify that Certifications is succsfully add or not 



@mytag
Scenario: Edit Certifications
	Given Navigate to Home Page and Click on the Signin button
	And  I click in Edit Button
	When I edit the Certificationsn record and dispaly the alert message
	Then I am verify that Certifications record is edit or not 




@mytag
Scenario: Delete Certifications
	Given Navigate to Home Page and Click on the Signin button
	And  I click in Delete Button
	When Delete the record and display the alert message
	Then I am verify that Certifications record is Delete 