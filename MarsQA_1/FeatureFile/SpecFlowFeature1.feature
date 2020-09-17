Feature: Cheaking Functionality of Mars Project
	

@mytag
Scenario: Register successfully
	Given Navigate to Home Page and Click on the Join Button
	Then I should be able to fill all the details in registration page
	Then I should be able to signup succesfully


@mytag
Scenario: Successfully SignIn
	Given Navigate to HomePage
	Then I should be able to login succesfully with valid creadential



@mytag
Scenario: Add Profile Details
     Given Navigate to Home Page and Click on the Signin button
	 Then I add the New Langauge
	 Then I edit the Langauge
	 Then I Delete the Language


@mytag
Scenario: Add Skill Details
     Given Navigate to Home Page and Click on the Signin button
	 Then I add the New Skill
	 Then I edit the Skill
	 Then I Delete the Skill


@mytag
Scenario: Add Education Details
     Given Navigate to Home Page and Click on the Signin button
	 Then I add the New Education
	 Then I Edit the Education
	 Then I Delete the Education


@mytag
Scenario: Add Certification Details
     Given Navigate to Home Page and Click on the Signin button
	 Then I add the Certification Details
	 Then I Edit Certification Details
	 Then I Delete Certification Details