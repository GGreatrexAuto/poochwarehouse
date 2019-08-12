Feature: Your Addresses


@mytag
Scenario: When logged in to the website the user should be able to add an address
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen
