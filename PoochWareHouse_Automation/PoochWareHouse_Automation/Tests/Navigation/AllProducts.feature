Feature: All Products

@WIP	
Scenario Outline: The next page and previous page buttons will navigate to the user to the appropriate all products page
	Given I access the all products page number '<pageNumber>'
		And I clear the cookie overlay
	When I click the '<navigationButton>' button
	Then the expected page number <expectedPageNumber> will be displayed

Examples: 
| pageNumber | navigationButton | expectedPageNumber |
| 1          | next             | 2                  |
| 2          | next             | 3                  |
| 2          | previous         | 1                  |
| 3          | previous         | 2                  |

@WIP
Scenario Outline: The next and previous buttons will be disabled if there is no page to navigate to
	Given I access the all products page number '<pageNumber>'
		And I clear the cookie overlay
	When the page navigation buttons are displayed
	Then the '<navigationButton>' button will be disabled

Examples: 
| pageNumber | navigationButton |
| 1          | previous         |
| 3          | next             |