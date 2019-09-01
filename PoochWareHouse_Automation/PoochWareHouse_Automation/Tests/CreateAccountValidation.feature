Feature: Create Account Validation

@WIP
Scenario: Attempting to create an account without providing an email address will not be permitted
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

@WIP
Scenario: Attempting to create an account without providing a password will not be permitted
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

@WIP
Scenario: Attempting to create an account using a previously registered email account will not be permitted
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

@WIP
Scenario: Attempting to create an account when providing an invalid email address will not be permitted
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen