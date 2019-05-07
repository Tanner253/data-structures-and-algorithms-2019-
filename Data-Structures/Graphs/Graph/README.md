# ***Graphs***
------------------------------

# Graph
#### *Author: Severus Snape*

------------------------------

## Description
a graph is like a binary tree and a linked list combined, where you traverse through the children nodes, and the nodes are scattered amongs the graph. 
the graph consits of vertexes in a dictionary as key value pairs, where the key represents the node and the value represents the value.

A C# implementation of a `Graph`. Singly Linked Lists contain individual nodes that have a reference to the `Next` node in the list as well as a `Value`. The methods of this `Graph` are Add, `Includes` and `Print`.

------------------------------

## Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| Add | Adds a new `Node` to the `Graph` | O(1) | O(1) | myList.Insert(Node) |
| AddDirected | Adds a new `Node` to the `Graph` where there is a direction on the flow of the traversal  | O(1) | O(1) | Graph.AddDirected(Node) |
| Print | Prints the `Graph` to the console | O(n) | O(1) | myList.Print() |


------------------------------

## Visuals
***[Add screenshots of your methods in action]***

##### Insert Method
***[In your own words explain what this method is doing]***
*The Insert Method takes in an int as a parameter. A new Node is then created using the* 
*int param as its Value. The new Node is then placed in the Linked List at the Head and*
*the previous Head is assigned as the new Nodes Next.*
![Image 1](https://via.placeholder.com/750x500)
##### Includes Method
***[In your own words explain what this method is doing]***
*The Includes Method takes in an int as a parameter then iterates through the Nodes of the*
*Linked List checking all the Values. If the value is found True is returned, if not then*
*False is returned.*
![Image 1](https://via.placeholder.com/750x500)
##### Print Method
***[In your own words explain what this method is doing]***
*The Print Method displays a well formatted depiction of the current state of the*
*Linked List by iterating over all Nodes.*
![Image 1](https://via.placeholder.com/750x500)

------------------------------

## Change Log
***[The change log will list any changes made to the code base. This includes any changes from TA/Instructor feedback]***
1.3: *Added new passing tests for Contains method* - 17 Nov 2012
1.2: *Fixed bug where Next relation was being lost on Insert* - 14 Nov 2012
1.1: *Fixed formatting for the Print method* - 13 Nov 2012

------------------------------

For more information on Markdown: https://www.markdownguide.org/cheat-sheet
