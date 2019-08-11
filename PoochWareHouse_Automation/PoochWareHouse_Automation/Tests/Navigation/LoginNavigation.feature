Feature: Login Navigation
	

Scenario: Logging in with valid credentials will navigate the user to the my account page
	Given I access the 'login' page
	And I clear the cookie notice
	When I enter 'valid' login credentials
	Then the 'My Account' page will be displayed

Scenario: Once logged in selecting the View address button will navigate the user to the your addresses page
	Given I access the My Account page
	When I select the view addresses button
	Then the Your Addresses page will be displayed

	Scenario: Once logged in selecting the log out link will navigate the user to the your addresses page
	Given I access the My Account page
	When I select the log out link
	Then the website homepage will be displayed