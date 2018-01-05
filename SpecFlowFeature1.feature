Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Open Fire Fox And Log In 
	Given I open firefox
	And I go to  http://www.demo.guru99.com/V4/
	When I enter the username of "mngr111939"
	And I enter the password of "ugAjuty"
	Then I should be successfully logged in with a greeting Welcome To Manager's Page of Guru99 Bank 
	And I clean the test environment

Scenario: Open Fire Fox And Failed Log In Incorrect Username
	Given I open firefox
	And I go to  http://www.demo.guru99.com/V4/
	When I enter the username of "11193"
	And I enter the password of "ugAjuty"
	Then I should recieve failed logged in with a message and be on the same URL "http://www.demo.guru99.com/V4/index.php"
	And I clean the test environment

Scenario: Open Fire Fox And Log In Failed Incorrect Password
	Given I open firefox
	And I go to  http://www.demo.guru99.com/V4/
	When I enter the username of "mngr111939"
	And I enter the password of "ugAy"
	Then I should recieve failed logged in with a message and be on the same URL "http://www.demo.guru99.com/V4/index.php"
	And I clean the test environment