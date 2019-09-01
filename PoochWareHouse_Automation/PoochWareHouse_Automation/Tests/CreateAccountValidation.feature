Feature: Create Account Validation

@WIP
Scenario: Attempting to create an account without providing an email address will not be permitted
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the error 'Email can't be blank.' will be displayed beneath the 'email' field
		And the error 'Email can't be blank.' will be displayed in the error section
		And the error section will change colour
		And the errored field ('email') will change colour

@WIP
Scenario: Attempting to create an account without providing a password will not be permitted
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the error 'Password can't be blank.' will be displayed beneath the 'password' field
		And the error 'Password can't be blank.' will be displayed in the error section
		And the error section will change colour
		And the errored field ('password') will change colour

@WIP
Scenario: Attempting to create an account using a previously registered email account will not be permitted
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the error 'Form This email address is already associated with an account. If this account is yours, you can reset your password' will be displayed in the error section
		And the error section will change colour

@WIP
Scenario: Attempting to create an account when providing an invalid email address will not be permitted
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the error 'Email is invalid.' will be displayed beneath the 'email' field
		And the error 'Email is invalid.' will be displayed in the error section
		And the error section will change colour
		And the errored field ('email') will change colour

@WIP
Scenario: Attempting to create an account when providing a password less than five characters in length is not permitted
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the error 'Password is too short (minimum is 5 characters).' will be displayed beneath the 'password' field
		And the error 'Password is too short (minimum is 5 characters).' will be displayed in the error section
		And the error section will change colour
		And the errored field ('password') will change colour