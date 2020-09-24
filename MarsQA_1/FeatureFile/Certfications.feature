Feature: Certifications
	Add,Edit,Delete(CRUD) for Certifications
	

@mytag
Scenario:1 Add new Certifications
	Given click in the Certifications tab
	When I click in the add new Certifications
	Then I am verify that Certifications is succsfully add or not 



@mytag
Scenario:2 Edit Certifications
	Given click in the Certifications tab
	And  I click in Edit Button for certifications
	When I edit the Certificationsn record and dispaly the alert message
	Then I am verify that Certifications record is edit or not 




@mytag
Scenario:3 Delete Certifications
	Given click in the Certifications tab
	And  I click in Delete Button for certificate
	