Feature: ProfileLanguage
	In order to update my profile 
	As a skill trader
	I can add,delete and edit Languages in my profile 


@automate
Scenario: as seller I should able to add language
	Given I login with valid user
	|Email				    |Password|
	|Myra.bamania@gmail.com |123456  |
	And I can add this language
	| Language | LanguageLevel |
	| English  | Basic |
	Then I can see added language  
	| Language | LanguageLevel |
	| English  | Basic |

	@automate
Scenario: as seller I should able to delete language
	Given I login with valid user
	|Email				    |Password|
	|Myra.bamania@gmail.com |123456  |
	And I can delete this language 
	| Language | LanguageLevel |
	| English  | Basic |
	Then I cannot see deleted language 
	| Language | LanguageLevel |
	| English  | Basic |

		@automate
Scenario: as seller I should able to Edit language
	Given I login with valid user
	|Email				    |Password|
	|Myra.bamania@gmail.com |123456  |
	And I can edit this language 
	| OldLanguage | OldLanguageLevel | NewLanguage | NewLanguageLevel |
	| English     | Basic    | Hindi       | Fluent   |
	Then I can see edited language  
	| OldLanguage | OldLanguageLevel | NewLanguage | NewLanguageLevel |
	| English     | Basic    | Hindi       | Fluent   |

