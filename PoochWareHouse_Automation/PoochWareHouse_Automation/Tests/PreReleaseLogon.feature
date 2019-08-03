@ComingSoon 
#@deprecated

Feature: Pre Release Logon
	In order to keep customers informed of poochwarehouse servies & products
	As a visitor to the site before prerelease
	I want to be able to leave my email contact address

Scenario: Customer opts to be notified of the store when it comes online with a valid email address
	Given I access the Poochwarehouse.co.uk website
		But the store is not online for business
		And the customer enters a valid email address to be notified of launch 
	When I press the notify me button
	Then the challenge contact password screen will be displayed

Scenario: An early access customer can opt to logon to the poochwarehouse site from the coming soon page when correct details are entered
	Given I access the Poochwarehouse.co.uk website
		But the store is not online for business
		And the customer selects the Enter Using Password button
		And the login page is displayed
		And the customer enters a valid password
	When the enter button is selected
	Then the poochwarehouse homepage will be displayed

Scenario: During the prerelease period people without the correct password cannot access the site
	Given poochwarehouse is not yet live
		And a potential customer attempts to access the site
		But enters an incorrect password
	When the enter button is selected
	Then an error will be displayed
		And the homepage will not be displayed