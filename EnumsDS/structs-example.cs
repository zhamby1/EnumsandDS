// using System.Collections.Generic;
// using System.Runtime.Serialization;

// //structures aloow us to hold more complicated data whic is reserved in memory and is related 
// //ie an object that has many properties that describe "one thing" or "one type of thing"
// //the data can be made up of multiple types
// //This is similar to a class minus function/methods

// //basically we are going to create our own "types"
// //lets us an Ogre for an example.  We want all ogres in our game to have a name and health value. 
// //but when one ogre gets hit we dont want the other ogres health value to decrease
// //they have the same type of data, but have different values inside depending on their state

// //the other purpose of a struct is to create a blueprint or copies of instances (struct being used), that can be used in multiple places

// //defining a struct
// struct Ogre{
//     //we add data or variables that will be used by the ogre
//     //in structs and classes we often call this properties or fields
//     //we then have to describe who can have access to the struct data..most of the time it will be public
//     //public means outside methods or other structs can access this data
//     //then we say datatype varname
//     public string Name;
//     public int Health;
    
// }
// //because we are now using multiple classes or structs, we have to create an entry point for the program to understand were the "Main"method or class lives
// class Program{

//     //this creates a main method where we can call other methods and classes from within it
//     public static void Main(string[] args){
        
//         //this creates an instance or copy of the class
//         Ogre ogre1;
//         ogre1.Name = "Green Ogre";
//         ogre1.Health = 100;

//         Console.WriteLine(ogre1.Name);
//         Console.WriteLine(ogre1.Health);

//         Ogre ogre2;
//         ogre2.Name = "Red Ogre";
//         ogre2.Health = 100;

        
      
//         Console.WriteLine(ogre2.Name);
//         Console.WriteLine(ogre2.Health);

//         //structs allow you to manipulate data and keep the data separate even though the structs are "the same type or thing"
//         ogre1.Health = ogre1.Health - 10;

        
//         Console.WriteLine(ogre1.Name);
//         Console.WriteLine(ogre1.Health);

        
//         Console.WriteLine(ogre2.Name);
//         Console.WriteLine(ogre2.Health);

//         //we can also use structs in lists

//         //when we use structs in lists we have to say the type of data
//         //because we used structs..structs become its own data type
//         List<Ogre> ogre_list = new List<Ogre>();
//         ogre_list.Add(ogre1);
//         ogre_list.Add(ogre2);

//         //display or iterate over a list of structs, we can use the foreach loop and just call the dot (.) notation after for the field/property we want to access

//         foreach(var ogre in ogre_list){
//             Console.WriteLine(ogre.Name);
//             Console.WriteLine(ogre.Health);
//         }
        

//         //foreach is read only
//         //for loop to get and change values

//         for(int i = 0; i < ogre_list.Count; i++){
//             Ogre current_ogre = ogre_list[i];
//             current_ogre.Health = current_ogre.Health - 50;
//             //applies changes to list
//             ogre_list[i] = current_ogre;             

//         }

//         foreach(var ogre in ogre_list){
//             Console.WriteLine(ogre.Name);
//             Console.WriteLine(ogre.Health);
//         }

//         //how many ogres to add to a list
//         Console.WriteLine("How many ogres to you wish to add ");
//         int number_to_add = int.Parse(Console.ReadLine());

//         for(int i = 0; i < number_to_add; i++){
//             Ogre add_ogre;
//             Console.WriteLine("Give me the name of the ogre");
//             string ogre_name = Console.ReadLine();
//             add_ogre.Name = ogre_name;
//             Console.WriteLine("Give me the health of the ogre");
//             int ogre_health = int.Parse(Console.ReadLine());
//             add_ogre.Health= ogre_health;
//             ogre_list.Add(add_ogre);
//         }

//         foreach(var ogre in ogre_list){
//             Console.WriteLine(ogre.Name);
//             Console.WriteLine(ogre.Health);
//         }
        



//     }
// }





