# Singly Linked List
This challenge highlights linked list, being able to add to a link list, and seeing if a node contains a value.

## Challenge
Implement a Singly Linked List Data Structure

## Approach & Efficiency
the approach i took was splitting everything up to classes and knocking out one thing at a time
O(1)
## API
the methods used in this porgram are 
LinkedList class -Print all() and Contains()
Append () AppendBeforeValue() AppendAfterValue()
# ***Data Structure Implementation***
------------------------------

# Linked List
#### *Author: Tanner Percival*

------------------------------

## Description
***The Linked list challenge creates and organizes a Linked List of nodes that all point to another node, connecting all the values.***

A C# implementation of a `Singly Linked List`. Singly Linked Lists contain individual nodes that have a reference to the `Next` node in the list as well as a `Value`. The methods of this `Linked List` are `Insert`, `Includes` and `Print`.

------------------------------

## Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| Insert | Adds a new `Node` to the `Linked List` | O(1) | O(1) | myList.Insert(99) |
| Includes | Takes in a value and returns a boolean depending on if the value is in the `LinkedList` | O(n) | O(1) | myList.Includes(99) |
| Print | Prints the `Linked List` to the console | O(n) | O(1) | myList.Print() |


------------------------------

## Visuals


##### Insert Method
The insert method Inserts a new node to the Head of the Linked list.
![Insert](/assets/insert.JPG)
##### Includes Method

This method reads a linked list and determines if a given value is present in the linked list
If the value is found True is returned, if not then False is returned.
![Includes](/assets/contains.JPG)
##### Print Method

The print method will write all of the values of each node in the linked list to the console.*
![Prints to console](/assets/print.JPG)

------------------------------

## Change Log
1.0 submits
2.0 submit 2  - fixes readme, adds summary comments, fixes functionality of LL assignment 1 and finishes tests
