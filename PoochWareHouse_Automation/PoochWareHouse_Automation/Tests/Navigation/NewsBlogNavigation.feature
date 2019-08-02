Feature: News and Blog Navigation

Scenario Outline: Accessing the news article links will navigate the user to the correct news article
	Given I access the '<pageName>' article page
		And dismiss the cookies overlay
	When I select the '<article>' article via the '<linkType>' link
	Then correct article '<expectedArticle>' will be displayed

	Examples: 
	| pageName    | article            | linkType | expectedArticle    |
	| News & Blog | Summer Is Here     | image    | Summer Is Here!    |
	| News & Blog | Summer Is Here     | button   | Summer Is Here!    |
	| News & Blog | Pooch Car Safety   | image    | Pooch Car Safety   |
	| News & Blog | Pooch Car Safety   | button   | Pooch Car Safety   |
	| News & Blog | Why Use a Harness? | image    | Why Use a Harness? |
	| News & Blog | Why Use a Harness? | button   | Why Use a Harness? |

Scenario Outline: Accessing the buttons and links in the news article pages will navigate the user to the correct page
	Given the news '<article>' is loaded
		And dismiss the cookies overlay
	When I select the '<hyperLink>'
	Then the '<expectedPage>' will be displayed

	Examples: 
	| article            | hyperLink               | expectedPage                                    |
	| Summer Is Here     | Back To News Button     | News                                            |
	| Pooch Car Safety   | Back To News Button     | News                                            |
	| Why Use a Harness? | Back To News Button     | News                                            |
	| Summer Is Here     | Summer Collection Image | Summer Time                                     |
	| Summer Is Here     | Travel Flask            | Water & Food Flask with Collapsible Travel Bowl |
	| Summer Is Here     | Summer Cooling Vest     | Summer Cooling Vest                             |
	| Summer Is Here     | Summer Cooling Scarf    | Summer Cooling Scarf                            |
	| Summer Is Here     | Thick Fur Grooming Comb | Thick Fur Grooming Comb                         |