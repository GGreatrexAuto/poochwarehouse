Feature: Informational Page Navigation
	
@WIP
Scenario Outline: Selecting hyperlinks within the informational page will navigate users to the correct location
	Given I access the '<informationalPage>' page
	And the '<hyperLink>' link is present
		When I click the '<hyperLink>'
	Then the '<expectedPage>' page will be loaded

	Examples:
	| informationalPage | hyperlink | expectedPage |
	| faq               |           |              |
	| privacy policy    |           |              |
	| returns policy    |           |              |
