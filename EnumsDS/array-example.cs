// //array is a data structures..data structures are ways to organize multiple pieces of data.
// //arrays are a data structure that have a fixed size and data type.  
// //we can loop over these to grab and manipulate data by it's index or position

// //in c# we initialize a new array with the "new" keyword
// //the "new" keyword creates an instance of a class or an instance of a pre-built typed method/class
// //Most things in C# are objects, so we we use data structures often times there is a class behind the scenese
// //classes are object templates with built in functions or methods


// //create a new array with ten items that can be held
// int[] sales = new int[10];
// //use the index or position of the array to add things to it
// sales[0] = 1000;
// sales[1] = 5000;
// sales[2] = 3000;

// //we can take input and add things to an array, just make sure it is converted
// Console.WriteLine("Enter a sales for the week");
// int sales_input = int.Parse(Console.ReadLine());
// sales[3] = sales_input;

// //to display or manipulate an array we must use a loop or other methods/functions
// for(int i = 0; i < sales.Length; i++)
// {
//     Console.WriteLine(sales[i]);
// }

// //to change data in an array you just have to call its index and new
// sales[0] = 500;

// for(int i = 0; i < sales.Length; i++)
// {
//     Console.WriteLine(sales[i]);
// }