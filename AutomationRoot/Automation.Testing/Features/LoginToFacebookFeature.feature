Feature: LoginFacebook
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: I can login to Facebook 
	Given I navigate to Facebook page
	When I login with "<userName>" and "<password>" 
	Then I can see my profile
	Examples: 
	|    userName      | password   |
	|    SomeUserName | SomePasword |
	|    <4qweuryo>      | 10     |