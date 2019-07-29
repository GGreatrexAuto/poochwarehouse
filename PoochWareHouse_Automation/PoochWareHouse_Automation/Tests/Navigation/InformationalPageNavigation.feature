Feature: Informational Page Navigation
	
@WIP
Scenario Outline: Selecting hyperlinks within the informational page will navigate users to the correct location
	Given I access the '<informationalPage>' page
	And the '<hyperLink>' link is present
		When I click the '<hyperLink>'
	Then the '<expectedPage>' page will be loaded

	Examples:
	| informationalPage | hyperlink                 | expectedPage   |
	| faq               | return policy link        | Returns Policy |
	| privacy policy    | homepage link one         | Home Page      |
	| privacy policy    | homepage link two         | Home Page      |
	| privacy policy    | all about cookies link    |                |
	| privacy policy    | shopify link              |                |
	| privacy policy    | google privacy link       |                |
	| privacy policy    | google opt out link       |                |
	| privacy policy    | facebook advertising link |                |
	| returns policy    | contact us link           | Contact Us     |
