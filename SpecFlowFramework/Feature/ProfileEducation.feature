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
	 | University          | Country     | Title | Degree | GraduationYear |
	 | Auckland Univercity | New Zealand |B.Tech | Bachlor | 2005          |
	Then I can see added education
	| University          | Country     | Title | Degree | GraduationYear |
	 | Auckland Univercity | New Zealand |B.Tech | Bachlor | 2005          |

@automate
Scenario: as seller I should able to delete Education
	Given I login with valid user
	|Email				    |Password|
	|Myra.bamania@gmail.com |123456  |
	And I can delete this education
	 | University          | Country     | Title | Degree | GraduationYear |
	 | Auckland Univercity | New Zealand |B.Tech | Bachlor | 2005          |
	Then I cannot see deleted education
	| University          | Country     | Title | Degree | GraduationYear |
	 | Auckland Univercity | New Zealand |B.Tech | Bachlor | 2005          |

@automate
Scenario: as seller I should able to edit Education
	Given I login with valid user
	|Email				    |Password|
	|Myra.bamania@gmail.com |123456  |
	And I can edit this education
	 | University          | Country     | Title  | Degree  | GraduationYear | NewUniversity | NewCountry  | NewTitle | NewDegree | NewGraduationYear |
	 | Auckland Univercity | New Zealand | B.Tech | Bachlor | 2005           | Waikato       | New Zealand | B.Sc     | Master    | 2008             |
	Then I can see edited education
	| University          | Country     | Title  | Degree  | GraduationYear | NewUniversity | NewCountry  | NewTitle | NewDegree | NewGraduationYear |
	| Auckland Univercity | New Zealand | B.Tech | Bachlor | 2005           | Waikato       | New Zealand | B.Sc     | Master    | 2008              |