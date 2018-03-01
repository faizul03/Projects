Feature: Office Locator 
As a user of the Jackon Hewitt website
I want to be able to find a office near me
	
	
@RegressionTest
@Browser:Chrome

Scenario:Office Locator 
	Given I have Navigate to jackson Hewitt Hompage 
	And I have entered <Zipcod> and <State> and <City>

	| ZipCode | State   | City     |
	| 72211   | Florida | New York |
	When I click find an office near you I should see list of offices
	And I should be able to Filter By
	And  Ishould be able to view office deatil  
	

	