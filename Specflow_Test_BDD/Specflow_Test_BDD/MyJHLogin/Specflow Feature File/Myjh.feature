Feature: 
    As a user of the website
    I want to log into the website
 
@Regression
Scenario: Successful Login with Valid Credentials
	Given Navigate to LogIn Page
	When User enter UserName and Password
	And Click on the LogIn button and enter access code
	Then Successful Logout message should display
 

