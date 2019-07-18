Feature: Site Navigation	

Scenario Outline: Confirm footer quick links navigate to the correct information page.
	Given I have accessed the PoochwareHouse website
	When I click the '<pageLink>' in the website footer
	Then the '<heading>' informational page will load
	
	Examples: 
	| pageLink            | heading             |
	| About Us            | About Us            |
	| FAQ                 | FAQ                 |
	| Delivery & Shipping | Delivery & Shipping |
	| Returns Policy      | Returns Policy      |
	| Privacy Policy      | Privacy Policy      |
	| Terms Of Use        | Terms Of Use        |
	| Contact Us          | Contact Us          |