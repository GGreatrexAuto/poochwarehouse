Feature: Login Validation

Background: 
	Given I access the login page

Scenario: When a user enters valid credentials then they will be permitted to access the my account area of the site
	Given valid credentials are entered
	When I press login
	Then the my account page will be displayed

Scenario: When a user adds an incorrect password then the user will not be permitted to enter the my account section
	Given an incorrect password is entered with a registered email address
	When I press login
	Then an error will be displayed stating 'Invalid login credentials.'
		And the username field will be cleared
		#And the username field colour will change
		And the password field will be cleared
		#And the password field colour will change
		And the my account page will not be displayed.

Scenario: When a user attempts to login with an email in an incorrect format then an error will be displayed
	Given an invalid email is entered
	When I press login
	Then an error will be displayed stating 'Invalid login credentials.'
		And the username field will be cleared
		#And the username field colour will change
		And the password field will be cleared
		#And the password field colour will change
		And the my account page will not be displayed.

Scenario: When a user attempts to login with an email account that has not been registered an error will be displayed
	Given an unregistered email account is used
	When I press login
	Then an error will be displayed stating 'Invalid login credentials.'
		And the username field will be cleared
		#And the username field colour will change
		And the password field will be cleared
		#And the password field colour will change
		And the my account page will not be displayed.