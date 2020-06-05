Feature: SignInFeature
	As a user i can login in to website

@mytag
Scenario: I can Login and Navigate to profile page
	Given I login with valid user
	|Email				    |Password|
	|Myra.bamania@gmail.com |123456  |
	Then I can navigate to profile page
	
