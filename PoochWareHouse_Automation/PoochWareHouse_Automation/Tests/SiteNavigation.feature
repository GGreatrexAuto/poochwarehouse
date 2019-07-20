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

	Examples: 
	| collectionLink     | heading            |
	| Beds & Blankets    | Beds & Blankets    |
	| Bowls & Food       | Bowls & Food       |
	| Grooming           | Grooming           |
	| Collars & Leads    | Collars & Leads    |
	| Health Care        | Health Care        |
	| Training           | Training           |
	| Small Dogs & Puppy | Small Dogs & Puppy |
	| Large Dogs         | Large Dogs         |
	| Toys & Games       | Toys & Games       |
	| On the go          | On The Go          |
	| Summer Time        | Summer Time        |
	| Winter Time        | Winter Time        |
	
Scenario Outline: Confirm collections drop down in header frame navigates to the correct products page
	Given I have accessed the PoochwareHouse website homepage
		And click the collections drop down option in the page header
	When I click the '<collectionsDropDown>' option on the drop down list
	Then the '<heading>' products collection page will load

	Examples: 
	| collectionsDropDown | heading            |
	| Beds & Blankets     | Beds & Blankets    |
	| Bowls & Food        | Bowls & Food       |
	| Grooming            | Grooming           |
	| Collars & Leads     | Collars & Leads    |
	| Health Care         | Health Care        |
	| Training            | Training           |
	| Small Dogs & Puppy  | Small Dogs & Puppy |
	| Large Dogs          | Large Dogs         |
	| Toys & Games        | Toys & Games       |
	| On the go           | On The Go          |
	| Summer Time         | Summer Time        |
	| Winter Time         | Winter Time        |

	@WIP
	Scenario Outline: Confirm non-collections links in the header frame navigate to the correcrt products page
	Given I have accessed the PoochwareHouse website homepage
	When I click the '<headerLink>' header option
	Then the '<heading>' products page wil load

	Examples: 
	| headerLink   | heading    |
	| On Sale      | Sale Items |
	| All Products | Products   |