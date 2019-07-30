Feature: News and Blog Navigation

Scenario Outline: Accessing the new article links will navigate the user to the correct news article
	Given I access the news and blog page
		And dismiss the cookies overlay
	When I select the '<article>' article via the '<linkType>' link
	Then correct article '<expectedArticle>' will be displayed

	Examples: 
	| article          | linkType | expectedArticle  |
	| Summer Is Here   | image    | Summer Is Here!  |
	| Summer Is Here   | button   | Summer Is Here!  |
	| Pooch Car Safety | image    | Pooch Car Safety |
	| Pooch Car Safety | button   | Pooch Car Safety |
