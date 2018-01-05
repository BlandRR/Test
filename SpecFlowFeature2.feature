Feature: SpecFlowFeature2
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Open Fire Fox And Log In 
	Given I open browser firefox
	And I go to URL  http://www.demo.guru99.com/V4/
	When I enter the username "mngr111939"
	And I enter the password "ugAjuty"
	Then I should be successfully logged in shown greeting Welcome To Manager's Page of Guru99 Bank 
	And I clean test environment

Scenario: New Customer with and empty name 
		Given I open browser firefox
	And I go to URL  http://www.demo.guru99.com/V4/
	When I enter the username "mngr111939"
	And I enter the password "ugAjuty"
	And I click new customer 
	And I enter a blank name 
	Then an error message should appear Customer name must not be blank  
	And I clean test environment


Scenario: New Customer with and contain numbers
		Given I open browser firefox
	And I go to URL  http://www.demo.guru99.com/V4/
	When I enter the username "mngr111939"
	And I enter the password "ugAjuty"
	And I click new customer 
	And I enter name Billy1
	Then an error message should appear Numbers are not allowed
	And I clean test environment

Scenario: New Customer with special characters
		Given I open browser firefox
	And I go to URL  http://www.demo.guru99.com/V4/
	When I enter the username "mngr111939"
	And I enter the password "ugAjuty"
	And I click new customer 
	And I enter name Billy!
	Then an error message should appear Special characters are not allowed
	And I clean test environment


Scenario: New Customer with first character blank
		Given I open browser firefox
	And I go to URL  http://www.demo.guru99.com/V4/
	When I enter the username "mngr111939"
	And I enter the password "ugAjuty"
	And I click new customer 
	And I enter name  Billy
	Then an error message should appear First character can not have space
	And I clean test environment


Scenario: New Customer with name/gender/dob/ Invalid address Empty
		Given I open browser firefox
	And I go to URL  http://www.demo.guru99.com/V4/
	When I enter the username "mngr111939"
	And I enter the password "ugAjuty"
	And I click new customer 
	And I enter name Billy
	And I enter date of birth 01/01/1990
	And I enter blankaddress
	Then Incorrect Address Field must not be blank
	And I clean test environment

Scenario: New Customer with name/gender/dob/ Invalid address First Character space
		Given I open browser firefox
	And I go to URL  http://www.demo.guru99.com/V4/
	When I enter the username "mngr111939"
	And I enter the password "ugAjuty"
	And I click new customer 
	And I enter name Billy
	And I enter date of birth 01/01/1990
	And I enter address  baker street
	Then Incorrect First character can not have space
	And I clean test environment

Scenario: New Customer with name/gender/dob/ Invalid address No special characters
		Given I open browser firefox
	And I go to URL  http://www.demo.guru99.com/V4/
	When I enter the username "mngr111939"
	And I enter the password "ugAjuty"
	And I click new customer 
	And I enter name Billy
	And I enter date of birth 01/01/1990
	And  I enter address baker street$
	Then Incorrect Special characters are not allowed
	And I clean test environment

Scenario: New Customer with name/gender/dob/address/ Invalid City blank
		Given I open browser firefox
	And I go to URL  http://www.demo.guru99.com/V4/
	When I enter the username "mngr111939"
	And I enter the password "ugAjuty"
	And I click new customer 
	And I enter name Billy
	And I enter date of birth 01/01/1990
	And  I enter address baker street
	And I enter BlankCity 
	Then CityBlank error City Field must not be blank
	And I clean test environment

Scenario: New Customer with name/gender/dob/address/ Invalid City contains special characters
		Given I open browser firefox
	And I go to URL  http://www.demo.guru99.com/V4/
	When I enter the username "mngr111939"
	And I enter the password "ugAjuty"
	And I click new customer 
	And I enter name Billy
	And I enter date of birth 01/01/1990
	And  I enter address baker street
	And I enterCity New York!
	Then CityBlank error Special characters are not allowed
	And I clean test environment

Scenario: New Customer with name/gender/dob/address/ Invalid City contains numbers
		Given I open browser firefox
	And I go to URL  http://www.demo.guru99.com/V4/
	When I enter the username "mngr111939"
	And I enter the password "ugAjuty"
	And I click new customer 
	And I enter name Billy
	And I enter date of birth 01/01/1990
	And  I enter address baker street
	And I enterCity New York01
	Then CityBlank error Numbers are not allowed
	And I clean test environment

Scenario: New Customer with name/gender/dob/address/ Invalid City First character empty
		Given I open browser firefox
	And I go to URL  http://www.demo.guru99.com/V4/
	When I enter the username "mngr111939"
	And I enter the password "ugAjuty"
	And I click new customer 
	And I enter name Billy
	And I enter date of birth 01/01/1990
	And  I enter address baker street
	And I enterCity  New York01
	Then CityBlank error First character can not have space
	And I clean test environment


Scenario: New Customer with name/gender/dob/address/City/ Invalid State with numbers
		Given I open browser firefox
	And I go to URL  http://www.demo.guru99.com/V4/
	When I enter the username "mngr111939"
	And I enter the password "ugAjuty"
	And I click new customer 
	And I enter name Billy
	And I enter date of birth 01/01/1990
	And  I enter address baker street
	And I enterCity New York
	And I enterState 1
	Then StateNumber error Numbers are not allowed
	And I clean test environment

Scenario: New Customer with name/gender/dob/address/City/ Invalid State blank
		Given I open browser firefox
	And I go to URL  http://www.demo.guru99.com/V4/
	When I enter the username "mngr111939"
	And I enter the password "ugAjuty"
	And I click new customer 
	And I enter name Billy
	And I enter date of birth 01/01/1990
	And  I enter address baker street
	And I enterCity New York
	And I blankState 
	Then StateNumber error State must not be blank
	And I clean test environment

Scenario: New Customer with name/gender/dob/address/City/ Invalid State special characters
		Given I open browser firefox
	And I go to URL  http://www.demo.guru99.com/V4/
	When I enter the username "mngr111939"
	And I enter the password "ugAjuty"
	And I click new customer 
	And I enter name Billy
	And I enter date of birth 01/01/1990
	And  I enter address baker street
	And I enterCity New York
	And I enterState bossland! 
	Then StateNumber error Special characters are not allowed 
	And I clean test environment

Scenario: New Customer with name/gender/dob/address/City/ Invalid State First Character Blank
		Given I open browser firefox
	And I go to URL  http://www.demo.guru99.com/V4/
	When I enter the username "mngr111939"
	And I enter the password "ugAjuty"
	And I click new customer 
	And I enter name Billy
	And I enter date of birth 01/01/1990
	And  I enter address baker street
	And I enterCity New York
	And I enterState  bossland 
	Then StateNumber error First character can not have space
	And I clean test environment


Scenario: New Customer with name/gender/dob/address/City/State/ Invalid Pin Character
		Given I open browser firefox
	And I go to URL  http://www.demo.guru99.com/V4/
	When I enter the username "mngr111939"
	And I enter the password "ugAjuty"
	And I click new customer 
	And I enter name Billy
	And I enter date of birth 01/01/1990
	And  I enter address baker street
	And I enterCity New York
	And I enterState bossland
	And I enterpin pa
	Then pinblank error Characters are not allowed
	And I clean test environment


Scenario: New Customer with name/gender/dob/address/City/State/ Invalid Pin Blank 
		Given I open browser firefox
	And I go to URL  http://www.demo.guru99.com/V4/
	When I enter the username "mngr111939"
	And I enter the password "ugAjuty"
	And I click new customer 
	And I enter name Billy
	And I enter date of birth 01/01/1990
	And  I enter address baker street
	And I enterCity New York
	And I enterState bossland
	And I blankpin
	Then pinblank error PIN Code must not be blank
	And I clean test environment


Scenario: New Customer with name/gender/dob/address/City/State/ Invalid Pin Special Character
		Given I open browser firefox
	And I go to URL  http://www.demo.guru99.com/V4/
	When I enter the username "mngr111939"
	And I enter the password "ugAjuty"
	And I click new customer 
	And I enter name Billy
	And I enter date of birth 01/01/1990
	And  I enter address baker street
	And I enterCity New York
	And I enterState bossland
	And I enterpin 1!
	Then pinblank error Special characters are not allowed
	And I clean test environment

Scenario: New Customer with name/gender/dob/address/City/State/ Invalid Pin only 5 digits
		Given I open browser firefox
	And I go to URL  http://www.demo.guru99.com/V4/
	When I enter the username "mngr111939"
	And I enter the password "ugAjuty"
	And I click new customer 
	And I enter name Billy
	And I enter date of birth 01/01/1990
	And  I enter address baker street
	And I enterCity New York
	And I enterState bossland
	And I enterpin 55555
	Then pinblank error PIN Code must have 6 Digits
	And I clean test environment

Scenario: New Customer with name/gender/dob/address/City/State/ Invalid First Character space
		Given I open browser firefox
	And I go to URL  http://www.demo.guru99.com/V4/
	When I enter the username "mngr111939"
	And I enter the password "ugAjuty"
	And I click new customer 
	And I enter name Billy
	And I enter date of birth 01/01/1990
	And  I enter address baker street
	And I enterCity New York
	And I enterState bossland
	And I enterpin  555555
	Then pinblank error First character can not have space
	And I clean test environment


Scenario: New Customer with name/gender/dob/address/City/State/Pin/ Telephone Invalid Blank
		Given I open browser firefox
	And I go to URL  http://www.demo.guru99.com/V4/
	When I enter the username "mngr111939"
	And I enter the password "ugAjuty"
	And I click new customer 
	And I enter name Billy
	And I enter date of birth 01/01/1990
	And  I enter address baker street
	And I enterCity New York
	And I enterState bossland
	And I enterpin 666666
	And I enterBlankTelephone 
	Then TelephoneBlank error Mobile no must not be blank
	And I clean test environment

Scenario: New Customer with name/gender/dob/address/City/State/Pin/ Telephone Invalid Special Characters
		Given I open browser firefox
	And I go to URL  http://www.demo.guru99.com/V4/
	When I enter the username "mngr111939"
	And I enter the password "ugAjuty"
	And I click new customer 
	And I enter name Billy
	And I enter date of birth 01/01/1990
	And  I enter address baker street
	And I enterCity New York
	And I enterState bossland
	And I enterpin 666666
	And I enterTelephone 00! 
	Then TelephoneBlank error Special characters are not allowed
	And I clean test environment

Scenario: New Customer with name/gender/dob/address/City/State/Pin/ Telephone Invalid contains characters
		Given I open browser firefox
	And I go to URL  http://www.demo.guru99.com/V4/
	When I enter the username "mngr111939"
	And I enter the password "ugAjuty"
	And I click new customer 
	And I enter name Billy
	And I enter date of birth 01/01/1990
	And  I enter address baker street
	And I enterCity New York
	And I enterState bossland
	And I enterpin 666666
	And I enterTelephone 00a 
	Then TelephoneBlank error Characters are not allowed
	And I clean test environment


Scenario: New Customer with name/gender/dob/address/City/State/Pin/ Telephone Invalid First Character blank
		Given I open browser firefox
	And I go to URL  http://www.demo.guru99.com/V4/
	When I enter the username "mngr111939"
	And I enter the password "ugAjuty"
	And I click new customer 
	And I enter name Billy
	And I enter date of birth 01/01/1990
	And  I enter address baker street
	And I enterCity New York
	And I enterState bossland
	And I enterpin 666666
	And I enterTelephone  00a 
	Then TelephoneBlank error First character can not have space
	And I clean test environment

Scenario: New Customer with name/gender/dob/address/City/State/Pin/Telephone/ Email Invalid Cannot be blank
		Given I open browser firefox
	And I go to URL  http://www.demo.guru99.com/V4/
	When I enter the username "mngr111939"
	And I enter the password "ugAjuty"
	And I click new customer 
	And I enter name Billy
	And I enter date of birth 01/01/1990
	And  I enter address baker street
	And I enterCity New York
	And I enterState bossland
	And I enterpin 666666
	And I enterTelephone 01112222
	And I enterBlankEmail
	Then InvalidEmail error Email-ID must not be blank
	And I clean test environment

Scenario: New Customer with name/gender/dob/address/City/State/Pin/Telephone/ Email Invalid must be valid
		Given I open browser firefox
	And I go to URL  http://www.demo.guru99.com/V4/
	When I enter the username "mngr111939"
	And I enter the password "ugAjuty"
	And I click new customer 
	And I enter name Billy
	And I enter date of birth 01/01/1990
	And  I enter address baker street
	And I enterCity New York
	And I enterState bossland
	And I enterpin 666666
	And I enterTelephone 01112222
	And I enteremail Billy
	Then InvalidEmail error Email-ID is not valid
	And I clean test environment

Scenario: New Customer with name/gender/dob/address/City/State/Pin/Telephone/ Email Invalid First Character Blank
		Given I open browser firefox
	And I go to URL  http://www.demo.guru99.com/V4/
	When I enter the username "mngr111939"
	And I enter the password "ugAjuty"
	And I click new customer 
	And I enter name Billy
	And I enter date of birth 01/01/1990
	And  I enter address baker street
	And I enterCity New York
	And I enterState bossland
	And I enterpin 666666
	And I enterTelephone 01112222
	And I enteremail  Billy
	Then InvalidEmail error First character can not have space
	And I clean test environment

Scenario: New Customer with name/gender/dob/address/City/State/Pin/Telephone/Email
		Given I open browser firefox
	And I go to URL  http://www.demo.guru99.com/V4/
	When I enter the username "mngr111939"
	And I enter the password "ugAjuty"
	And I click new customer 
	And I enter name Billy
	And I enter date of birth 01/01/1990
	And  I enter address baker street
	And I enterCity New York
	And I enterState bossland
	And I enterpin 666666
	And I enterTelephone 01112222
	And I enteremail Billy@msn.com
	And I enterBlankPassword 
	Then InvalidPassword error Password must not be blank
	And I clean test environment

Scenario: New Customer with name/gender/dob/address/City/State/Pin/Telephone/Email/Password Successful
		Given I open browser firefox
	And I go to URL  http://www.demo.guru99.com/V4/
	When I enter the username "mngr111939"
	And I enter the password "ugAjuty"
	And I click new customer 
	And I enter name Billy
	And I enter date of birth 11111111
	And  I enter address baker street
	And I enterCity New York
	And I enterState bossland
	And I enterpin 666666
	And I enterTelephone 01112222
	And I enteremail Bilghjghjly@msn.com
	And I enterPassword Billy01
	Then CustomerCreationSuccessful Customer Registered Successfully!!!
	And I clean test environment