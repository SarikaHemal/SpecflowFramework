Feature: ProfileCertificate
	In order to update my profile 
	As a skill trader
	I can add,delete and edit Certificate in my profile 


@automate
Scenario: as seller I should able to add Certificate
	Given I login with valid user
	| Email                  | Password |
	| Myra.bamania@gmail.com | 123456   |
	And I can add this Certificate
	| Certificate | From        | Year |
	| IC          | New Zealand | 2009 |
	Then I can see added Certificate
	| Certificate | From        | Year |
	| IC          | New Zealand | 2009 |

	
@automate
Scenario: as seller I should able to delete Certificate
	Given I login with valid user
	| Email                  | Password |
	| Myra.bamania@gmail.com | 123456   |
	And I can delete this Certificate
	| Certificate | From        | Year |
	| IC          | New Zealand | 2009 |
	Then I cannot see deleted Certificate
	| Certificate | From        | Year |
	| IC          | New Zealand | 2009 |

	@automate
Scenario: as seller I should able to Edit Certificate
	Given I login with valid user
	| Email                  | Password |
	| Myra.bamania@gmail.com | 123456   |
	And I can edit this Certificate
	| Certificate | From        | Year | NewCertificate | NewFrom | NewYear |
	| IC          | New Zealand | 2009 | Unitec         | UK      | 2007    |
	Then I can see edited Certificate
	| Certificate | From        | Year |NewCertificate | NewFrom | NewYear |
	| IC          | New Zealand | 2009 | Unitec         | UK      | 2007    |