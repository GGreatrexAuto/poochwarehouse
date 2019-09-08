Feature: Create Account Validation

#@WIP
Scenario Outline: Attempting to create an account without providing an email address will not be permitted
	Given I access the create account page
	And do not enter an email address
	And enter a valid password
	When I press create account button
	Then the error '<errorMessage>' will be displayed beneath the 'email' field
		And the error '<errorMessage>' will be displayed in the error section
		And the error section will change colour
		And the errored field ('email') will change colour

Examples: 
| errorMessage          |
| Email can't be blank. |


@WIP
Scenario Outline: Attempting to create an account without providing a password will not be permitted
	Given I access the create account page
	And enter a valid email address
	And do not enter a password
	When I press create account button
	Then the error '<errorMessage>' will be displayed beneath the 'password' field
		And the error '<errorMessage>' will be displayed in the error section
		And the error section will change colour
		And the errored field ('password') will change colour

Examples:
| errorMessage             |
| Password can't be blank. |

@WIP
Scenario Outline: Attempting to create an account using a previously registered email account will not be permitted
	Given I access the create account page
	And enter an email address that has previously been registered
	And enter a valid password
	When I press create account button
	Then the error '<errorMessage>' will be displayed in the error section
		And the error section will change colour

Examples: 
| errorMessage                                                                                                         |
| Form This email address is already associated with an account. If this account is yours, you can reset your password |

@WIP
Scenario Outline: Attempting to create an account when providing an invalid email will not be permitted
	Given I access the create account page
	And enter an invalid formatted email address
	And enter a valid password
	When I press create account button
	Then the error '<errorMessage>' will be displayed beneath the 'email' field
		And the error '<errorMessage>' will be displayed in the error section
		And the error section will change colour
		And the errored field ('email') will change colour

Examples: 
| errorMessage      |
| Email is invalid. |

@WIP
Scenario Outline: Attempting to create an account when providing a password less than five characters in length is not permitted
	Given I access the create account page
	And enter a valid email address
	And enter a password less than 5 characters in length
	When I press create account button
	Then the error '<errorMessage>' will be displayed beneath the 'password' field
		And the error '<errorMessage>' will be displayed in the error section
		And the error section will change colour
		And the errored field ('password') will change colour

Examples:
| errorMessage                                     |
| Password is too short (minimum is 5 characters). |