@ComingSoon

Feature: Pre Release Logon
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario: Customer opts to be notified of the store when it comes online with a valid email address
	Given I access the Poochwarehouse.co.uk website
		But the store is not online for business
		And the customer enters a valid email address to be notified of launch 
	When I press the notify me button
	Then the challenge contact password screen will be displayed
