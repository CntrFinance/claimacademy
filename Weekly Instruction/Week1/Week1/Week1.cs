using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    public class Week1
    {
        public static void Main(string[] args)
        {
            // Week 1

            {

            }

        }

        public static void DataTypes()
        {
            // Data Types (Primitive types)
            // Microsft C# Documentation- https://learn.microsoft.com/en-us/dotnet/csharp/
            Integers();
            FloatingPointTypes();
            Booleans();
            Character();
            Strings();
            UserInput();
            Abstractions();
            Constructors();
            Polymorphism();
            Interface();
        }

        public static void Integers()
        {
            //Integer: Whole numbers. 32-bit values go up to 2,147,483,647. The equation is (2^32/ 2) -1 = 2,147,483,647
            //int.MaxValue; Max value of an integer.

            Console.WriteLine($"Max Integer Value:{int.MaxValue}");

            ////Declare without initial assignment
            int num; //All statements must end with a semi colomn;

            Console.WriteLine($"Max Integer Value:{int.MaxValue}");


            ////int64.MaxValue = 64-bit Integers can be accessed with int.64 struct or 
            ////. Max Integer size 18446744073709551615


            //// Assignment: Giving a value to the variable 

            num = 6;

            ////We can also declare and assign a value at once.

            int num2 = 8;

        }

        public static void FloatingPointTypes()
        {
            //// Doubles- Floating numbers, with decimals: Range ±5.0 × 10−324 to ±1.7 × 10308

            double dbl = 1.25d;

            //// Floats Decimals: Range ±1.5 x 10−45 to ±3.4 x 1038

            float floatnum = 4.7589f;

            ////Decimal type:: Range ±1.0 x 10-28 to ±7.9228 x 1028
            decimal decimalnum = 8.567m;

        }

        public static void Booleans()
        {
            // Boolean:  Can only be True or False, used to determine the binary state of something. ie 


            bool booltrue = true;
            bool boolfalse = false;

        }

        public static void Character()
        {
            //Characters: Single ASCII or UTF-8 value ( Depending on charater set used, these are the most common character sets)
            //For char we use '' single quotes not ("")
            char lowerA = 'a';
            char upperA = 'A';

            int lowerAValue = (int)lowerA;
            Console.WriteLine($"Integer value of lower-casea:{lowerA}");


        }

        public static void Strings()
        {

            //Strings- Arrays of character 
            string helloWorld = "Hello Wolrd";

            //Convert to character array

            char[] helloWorldCharArray = helloWorld.ToCharArray();
            // anything yellow is a method.
        }

        public static void UserInput()
        {

            // User Input 
            Console.WriteLine();// Will create a new line under text

            Console.Write("Enter your name"); // Console.Write will not create a new line stops at the text
            // We will declare a string variable called "name" and assign the user inout to the string.

            string name = Console.ReadLine();
            //Will create the string variable name and then await keyboard input from user iin the console.after taking inthe user input from the keyboard
            //we will print back the text the user typed

            Console.WriteLine($"Your name is {name}");
            Console.ReadKey(); // Keep console window open until key is pressed end to program 

           // Ctrl + K + C = turn higlighted text into comment

        }
        public static void ForLoop()
        {
            //For Loops

            // Declare count variable for loop count
            
            int count = 10;
            
            for (int i = 0; i < count; i++) ;

            //First statement is i = 0; Initializes a counter i and starts at 0
            // Second statement : i < count; Loop while i is less than the count, loop will stop when i = count
            // Third statement: Increment (increase 1, 2, 3, 4, 5) i by 1 for each execution of the loop.
            // By structuring the for statement like this, starting at 0, and increasing by 1 until i is less than 10.
            // The next loop , i will equal 10, which stops the loop, so the last execution of the loop, i is 9.
            // Since we are starting from 0, and going to 9,this is exactly 10 executions of the loop.

            //Do something with each execution of the loop
            int i= 0; 
             Console.WriteLine($"Loop count i {i},but this is execution number {i + 1}.");
        }
        public static void ForEachLoop()
        { 
            //Foreach Loop - Use an Array or List to Loop through the Array/List/Collection.

            //Interger Array of 10 values
            //Size of Array is used to control how many times the Loop runs for (loop runs from the begging of Array)
            int[] tenCountArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int i in tenCountArray) ;


        }
        public static void Constructors()
        {

        }
        public static void Polymorphism()
        {

        }

        public static void Interface()
        {


        }

        public static void Abstractions()
        {


        }
    }
}
