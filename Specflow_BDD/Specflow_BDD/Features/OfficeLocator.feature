Feature: OfficeLocator
	Feature to test Jh office locator functionality
	Here we will test list of result as well as navigating to search result

@SmokeTest
@Browser:Chrome
Scenario: jh search for zipcode
	Given I have navigated to jh homepage 
	And I see the jh homepage fully loaded
	When I type search zipcode as
		| zipcode |
		| 72211   |

	Then I should see the result for zipcode
		| zipcode |
		| 72211   |  
