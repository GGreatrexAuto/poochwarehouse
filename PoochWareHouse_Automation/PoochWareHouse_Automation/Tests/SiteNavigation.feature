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

	#@WIP
	Scenario Outline: Confirm non-collections links in the header frame navigate to the correct products page
	Given I have accessed the PoochwareHouse website homepage
	When I click the '<headerLink>' header option
	Then the '<heading>' products page will load

	Examples: 
	| headerLink   | heading    |
	| On Sale      | Sale Items |
	| All Products | Products   |
	| Login        | Login      |
	| Your Cart    | Your cart  |
	
	@WIP
	Scenario Outline: Confirm homepage button or poochwarehouse image will navigate the user back to the poochwarehouse homepage
	Given I access the poochwarehouse '<webpage>' page
	When I click the '<homepageNavigationType>' option
	Then the user will be navigated to the poochwarehouse homepage

	Examples: 
	| webpage           | homepageNavigationType |
	| sale-items        | Homepage header        |
	| all-products      | Homepage header        |
	| beds-blankets     | Homepage header        |
	| bowls-food        | Homepage header        |
	| health-grooming   | Homepage header        |
	| collars-leads     | Homepage header        |
	| health-care       | Homepage header        |
	| training          | Homepage header        |
	| small-dogs        | Homepage header        |
	| large-dogs        | Homepage header        |
	| toys-games        | Homepage header        |
	| on-the-go         | Homepage header        |
	| summer-collection | Homepage header        |
	| winter-collection | Homepage header        |
	| login             | Homepage header        |
	| your-cart         | Homepage header        |
	| about-us          | Homepage header        |
	| faq               | Homepage header        |
	| delivery-shipping | Homepage header        |
	| returns-policy    | Homepage header        |
	| privacy-policy    | Homepage header        |
	| terms-of-use      | Homepage header        |
	| contact-us        | Homepage header        |
	| sale-items        | PoochWarehouse logo    |
	| all-products      | PoochWarehouse logo    |
	| beds-blankets     | PoochWarehouse logo    |
	| bowls-food        | PoochWarehouse logo    |
	| health-grooming   | PoochWarehouse logo    |
	| collars-leads     | PoochWarehouse logo    |
	| health-care       | PoochWarehouse logo    |
	| training          | PoochWarehouse logo    |
	| small-dogs        | PoochWarehouse logo    |
	| large-dogs        | PoochWarehouse logo    |
	| toys-games        | PoochWarehouse logo    |
	| on-the-go         | PoochWarehouse logo    |
	| summer-collection | PoochWarehouse logo    |
	| winter-collection | PoochWarehouse logo    |
	| login             | PoochWarehouse logo    |
	| your-cart         | PoochWarehouse logo    |
	| about-us          | PoochWarehouse logo    |
	| faq               | PoochWarehouse logo    |
	| delivery-shipping | PoochWarehouse logo    |
	| returns-policy    | PoochWarehouse logo    |
	| privacy-policy    | PoochWarehouse logo    |
	| terms-of-use      | PoochWarehouse logo    |
	| contact-us        | PoochWarehouse logo    |