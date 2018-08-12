# DecisionTech.ShoppingBasket

I have used the factory method pattern to create the products, and the decorator pattern 
to apply the single responsibility principle. The scenarios outlined in the instructions 
have been implemented as acceptance tests in the tests project. I have tried to make the 
algorithm for the 50% of the bread algorithm calculation more readable through the use of 
functions named after each stage in the algorithm. Other than use SOLID principles and 
TDD I have not implemented anything other than what was outlined in the instructions; the app 
has no UI and can only be run through tests. 

The creation of the basket objects should be abstracted for the consumer, however that 
consumer is not needed to meet the instructions, and so that was not included. None-the-less
it does feel like a jagged edge in the code.

There should be some separation between the interfaces and their implementations so that 
consumers can reference the interfaces without the implementations, however the consumer 
is not required to meet the spec and so this was not done. 

The IProductFactory interface is not strictly necessary to meet the instructions, but is part 
of the factory method pattern, and therefore might be expected by programmers looking at the code. 
It is therefore included; to avoid surprising other developers.

I am interested to know your thoughts, how it might be improved and how readable it is.
