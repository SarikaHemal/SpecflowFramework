Feature: ProfileEdit
	In order to update my profile 
	As a skill trader
	I can add,delete and edit my profile 


@automate
Scenario: as seller I should able to change my password
	Given I login with valid user
	|Email				    |Password|
	|Myra.bamania@gmail.com |123456  |
	And I click Change Password option under user name and sign out
	Then I can login with changed password
	