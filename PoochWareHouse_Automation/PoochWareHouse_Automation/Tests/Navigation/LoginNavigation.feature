Feature: Login Navigation
	

Scenario: Logging in with valid credentials will navigate the user to the my account page
	Given I access the 'login' page
	And I clear the cookie notice
	When I enter 'valid' login credentials
	Then the 'My Account' page will be displayed
