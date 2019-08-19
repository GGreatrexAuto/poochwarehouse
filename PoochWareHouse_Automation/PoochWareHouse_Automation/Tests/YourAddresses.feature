Feature: Your Addresses


#@WIP
@DeleteAddress
Scenario: When logged in to the website the user should be able to add an address
	Given I access my account
	And click the View Addresses button
	And click Add A New Address
	And enter 'valid' address details
	When I press Add Address
	Then the default address details will be saved as entered
