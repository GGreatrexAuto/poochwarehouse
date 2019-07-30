Feature: Informational Page Navigation
	
#@WIP
Scenario Outline: Selecting hyperlinks within the informational page will navigate users to the correct location
	Given I access the '<informationalPage>' page
	And I clear the cookie notice
	And the '<hyperLink>' link is present
		When I click the '<hyperLink>'
	Then the '<expectedPage>' page will be loaded

	Examples:
	| informationalPage | hyperLink                 | expectedPage         |
	| faq               | return policy link        | Returns Policy       |
	| privacy policy    | homepage link one         | Home Page            |
	| privacy policy    | homepage link two         | Home Page            |
	| privacy policy    | all about cookies link    | All About Cookies    |
	| privacy policy    | shopify link              | Shopify Privacy      |
	| privacy policy    | google privacy link       | Google Privacy       |
	| privacy policy    | google opt out link       | Google Opt Out       |
	| privacy policy    | facebook advertising link | Facebook Data Policy |
	| returns policy    | contact us link           | Contact Us           |
