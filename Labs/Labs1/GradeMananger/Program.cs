using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeMananger
{
    public class Program
        // Global Scope
    {
        public static void Main(string[] args)
            //Commit MOTO: commit often and commit early
            // Local Scope
        {
            string applicationName = "Grade Manager"; // Declare application name as a string 

            Console.WriteLine(applicationName); // Console calls on our string inside a method that pulls up the console: The user will see the string defintion " Greade Manager".
            
            Console.WriteLine(new String('-', applicationName.Length)); //  Imagine the word is "applicationName," which has 15 letters. Here's how it works.
                                                                        //Count the letters in "applicationName." There are 15 letters.
                                                                        //Make a line of dashes that is 15 dashes long: "---------------".
                                                                        //Show this line of dashes on the screen.


            //Console.WriteLine(string.Empty); //Create Blank Line To the Start Menu
            Console.WriteLine('\n');//\n is a special character in programming known as a newline character. When used in a string, it tells the computer to move the cursor to the next line. Essentially, it starts a new line of text.



            Console.WriteLine("1. Print all student grade.");
            Console.WriteLine("2. Add studemt grade");
            Console.WriteLine("3. Calculate class average.");
            Console.WriteLine("4. Print highest grade.");
            Console.WriteLine("5. Print lowest grade.");
            Console.WriteLine("6. Delete student.");
            Console.WriteLine("7. Edit student grade.");
            Console.WriteLine("8. Exit.");
            Console.WriteLine("\n"); //Line Break
            Console.WriteLine("Enter a grade."); //User Input
            Console.ReadKey();

            string choiceInput = Console.ReadLine(); //Keyboard input is always a string.
            int choice = int.Parse(choiceInput); // Parse changes string into int. If there is no int program will crash because we havent as

            switch (choice)
            {
                case 1:
                    
                    //Print student grade method for 1st choice.
                    break;  // After each case you have to end it with a break statement,otherwise all cases will execute.
                case 2:
                    // Add student grade
                    break;
                case 3:
                    //Calculate class average
                    break;
                case 4:
                    //Print highest grade
                    break;
                case 5:
                    //Print lowest grade
                    break;
                case 6:
                    //Delete student
                    break;
                case 7:
                    //Add student grade
                    break;
                case 8:
                    // Exit
                    break;

                default:   //Execute default case if chaoice does not match any other cases. we add no code and just put break statement which will end the switch block.
                    break; 
            }
        }

    }
}
