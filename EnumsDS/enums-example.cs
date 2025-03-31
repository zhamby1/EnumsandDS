// using System.Collections.Generic;

// //enums are integers (special structs) that have been turned into names
// //They represent states or states of being
// //for example if I had a color enum, the color could only be in a state of lets say red, green, or blue
// //US states are a good example as a state can only be one of the 50 states

// //this is good to create a list of choices where the choices are known

// //at the end of a course, you can either Pass, Fail, or Drop a course

// //enums use the keyword enum, and this a list of different "states"
// enum Course_Status{
//     Pass,
//     Fail,
//     Drop
// }
// class Program{

//     //this creates a main method where we can call other methods and classes from within it
//     public static void Main(string[] args){

//         Course_Status sdev_248;
//         sdev_248 = Course_Status.Pass;

//         //what we usually use states for is in if-else statemetents to check for something

//         if(sdev_248 == Course_Status.Pass){
//             Console.WriteLine("You passed");
//         }

//         else{
//             Console.WriteLine("You Failed or Dropped");
//         }


//         //the use for this in game design is very apparent when using state machines
//         //state machines check the current state of something and transition the code to do something when in a specific state
//         //i.e. if the game state is playing then the user can control the character on screen.
//         //if the game state is game_over then the character can no longer be moved.





    
        
//     }
// }





