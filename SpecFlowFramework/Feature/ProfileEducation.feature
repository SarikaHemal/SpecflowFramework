Feature: ProfileEducation
	In order to update my profile 
	As a skill trader
	I can add,delete and edit Education in my profile 


@automate
Scenario: as seller I should able to add Education
	Given I login with valid user
	|Email				    |Password|
	|Myra.bamania@gmail.com |123456  |
	And I can add this education
	 | University          | Country     | Tital | Degree | GraduationYear |
	 | Auckland Univercity | New Zealand |B.Tech | Bachlor | 2005          |
	Then I can see added education
	