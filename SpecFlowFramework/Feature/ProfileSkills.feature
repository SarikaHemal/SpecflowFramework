Feature: ProfileSkill
	In order to update my profile 
	As a skill trader
	I can add,delete and edit Skills in my profile 


@automate
Scenario: as seller I should able to add skills
	Given I login with valid user
	|Email				    |Password|
	|Myra.bamania@gmail.com |123456  |
	And I can add this Skills
	| Skill | SkillLevel	|
	| QA	|Intermediate   |
	Then I can see added Skills 
	| Skill | SkillLevel	|
	| QA	|Intermediate   |

@automate
Scenario: as seller I should able to Delete skills
	Given I login with valid user
	|Email				    |Password|
	|Myra.bamania@gmail.com |123456  |
	And I can delete this Skills
	| Skill | SkillLevel	|
	| QA	|Intermediate   |
	Then I cannot see deleted Skills 
	| Skill | SkillLevel	|
	| QA	|Intermediate   |

@automate
Scenario: as seller I should able to edie skills
	Given I login with valid user
	|Email				    |Password|
	|Myra.bamania@gmail.com |123456  |
	And I can edit this Skills
	| OldSkill | OldSkillLevel | NewSkill | NewSkillLevel |
	| QA       | Intermediate  | Devloper | Beginner      |
	Then I can see edited Skills 
	| OldSkill | OldSkillLevel	|NewSkill|NewSkillLevel|
	| QA	|Intermediate   |Devloper | Beginner      |