Feature: SpecFlowFeaturesample
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

	Scenario: Create a new employee with mandatary details
	#Given I have Open my application
	#Then I should see employee detail page
	When I fill all the mandatory detail in form
	| Name   | Age | Phone      | Email                 |
	| Faizul | 29  | 9173047858 | faizul.islam@jtax.com |
	| Sam    | 30  | 2125659200 | abc@gnail.com         |
	| Adam   | 30  | 2125659201 | abb@gnail.com         |
	| Jhon   | 39  | 9125659200 | aaa@gnail.com         |
	| Jhon   | 33  | 9125659200 | aaa@gnail.com         |
	| Jhon   | 38  | 9125659200 | aaa@gnail.com         |
	| Jhon   | 50  | 9125659200 | aaa@gnail.com         |

	#And I click the save button
	#Then I should see all the details saved in my application and BD
