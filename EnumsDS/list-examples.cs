// //in an array list we can dynamically update arrays so they do not have a fixed size
// //to use an array list or list we have to import the collections namespace/library
// using System.Collections.Generic;

// //create an array list / list of sales
// //make every entry an int and we will add data by using the add() function.method

// //list of ints called sales = new instance of List
// List<int> sales = new List<int>();

// //add function or method to add things to a list

// sales.Add(8000);
// sales.Add(5000);
// sales.Add(1000);

// //we could use a tradition for loop to grab the items, but lists have other features that make it easier

// //we will use a for each loop.  a for each loop allows you to iterate over a list outside of a traditional for loop
// //we create a variable name that represents a single item in the list (like i) as it is looping through it
// //similar to for in loop in python

// //often we using foreach we use a singular version of the lists name
// foreach(var sale in sales){
//     Console.WriteLine(sale);
// }

// //we can use methods to manipulate a list
// //remove - remove based on a value vs an index
// sales.Remove(5000);
// foreach(var sale in sales){
//     Console.WriteLine(sale);
// }


// //sort smallest to largest
// sales.Sort();
// foreach(var sale in sales){
//     Console.WriteLine(sale);
// }

// //check to see if something is in a list with BinarySearch

// int find = sales.BinarySearch(1000);
// Console.WriteLine(find);
