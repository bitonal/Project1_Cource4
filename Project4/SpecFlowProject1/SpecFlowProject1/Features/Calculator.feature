Feature:Joe’s Pizza

Placing a pizza order 

@tag1
Scenario: pizza order should be placed by me 
	Given i have to navigate to home page
	Then click on list pizza and add pizza to cart
	Then click order button and add pizza to cart
	Then click on order  butoon to check order list
	Then add  pizzas and payment
	When click on checkout button order should be placed