Feature: Site Navigation	

Scenario Outline: Confirm footer quick links navigate to the correct information page.
	Given I have accessed the PoochwareHouse website homepage
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

Scenario Outline: Confirm collections section links navigate to the correct products page
	Given I have accessed the PoochwareHouse website homepage
	When I click the '<collectionLink>' in the collections frame
	Then the '<heading>' products collection page will load
		And the products description for the collection will be correct

	Examples: 
	| collectionLink            | heading             |
	| Beds & Blankets            | Beds & Blankets            |
	| Bowls & Food                 | Bowls & Food                 |
	| Grooming | Grooming |
	| Collars & Leads      | Collars & Leads      |
	| Health Care     | Health Care      |
	| Training        | Training        |
	| Small Dogs & Puppies          | Small Dogs & Puppies          |
	| Large Dogs          | Large Dogs          |
	| Toys & Games          | Toys & Games          |
	| On the go          | On the go          |
	| Summertime          | Summertime          |
	| Wintertime          | Wintertime          |