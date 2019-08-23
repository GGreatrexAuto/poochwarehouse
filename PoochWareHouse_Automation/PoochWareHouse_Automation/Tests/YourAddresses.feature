Feature: Your Addresses


@DeleteAddress
Scenario: When logged in to the website the user should be able to add an address
	Given I access my account
		And click the View Addresses button
		And click Add A New Address
		And enter 'valid' address details
	When I press Add Address
	Then the default address details will be saved as entered

@DeleteAddress 
Scenario: When logged in to the site the user should be able to add more than one address
	Given I login and add a default address
		And then add a second address
	When I press Add Address
	Then the second added address will be saved as entered
		And the default address details will be saved as entered
		
