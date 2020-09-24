Feature: Languages
	Add,Edit,Delete(CRUD) for Language
	

@mytag
Scenario:1 Add new Language
	Given click on the Language tab
	When I click on the add new language 
	Then I verify that language is successfully add or not 



@mytag
Scenario:2 Edit Language
	Given  I click in Edit Button
	When I edit the Language record and dispaly the alert message
	Then I am verify that language record is edit or not 




@mytag
Scenario:3 Delete Language
	 Given  I click in Delete Button
	
	