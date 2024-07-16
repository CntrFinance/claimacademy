using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GradeMananger
{
    public class GradeManager
        // Global Scope
        
    {
        private static readonly string applicationName = "Grade Manager";
        private static bool exit = false;
        public static void Main(string[] args)
        //Commit MOTO: commit often and commit early
        // Local Scope
        {
      

            Console.WriteLine(applicationName); // Console calls on our string inside a method that pulls up the console: The user will see the string defintion " Greade Manager".

            Console.WriteLine(new String('-', applicationName.Length)); //  Imagine the word is "applicationName," which has 15 letters. Here's how it works.
                                                                        //Count the letters in "applicationName." There are 15 letters.
                                                                        //Make a line of dashes that is 15 dashes long: "---------------".
                                                                        //Show this line of dashes on the screen.

            Console.WriteLine(string.Empty); //Create Blank Line To the Start Menu
            Console.WriteLine('\n');//\n is a special character in programming known as a newline character. When used in a string, it tells the computer to move the cursor to the next line. Essentially, it starts a new line of text.

            //Create some Student 
            var students = new List<Student>()//create a list of students and instatiate (create) the students from the start.
            {
                new Student("Jibreel", "Muhammad"), //Student 0 (Student number is indexer (Position) number in list)
                new Student("Hassan", "Fofana"), //Student 1
                new Student("Tavish", "Misra"), //Student 2
                new Student("Jarvis", "Potter"), //Student 3
                new Student("Greg", "Leeker") // Student 4

            };//create a list of students and instatiate (create) the students from the start. We call the new keyword on each studnet object in the list because wach student object must be created.

            while (!exit) //! = not false
            {
                menu(students);
            }
        }

        private static void menu(List<Student>students)
        {
            Console.WriteLine("1. Print all student grade.");
            Console.WriteLine("2. Add studemt grade");
            Console.WriteLine("3. Calculate class average.");
            Console.WriteLine("4. Print highest grade.");
            Console.WriteLine("5. Print lowest grade.");
            Console.WriteLine("6. Delete student.");
            Console.WriteLine("7. Edit student grade.");
            Console.WriteLine("8. Exit.");
            Console.WriteLine("\n"); //Line Break
            Console.WriteLine("Enter a choice."); //User Input


            string choiceInput = Console.ReadLine(); //Keyboard input is always a string.
            int choice = int.Parse(choiceInput); // Parse changes string into int. If there is no int program will crash because we havent as

            switch (choice)
            {
                case 1:

                    PrintStudentGrade(students); // method for 1st choice.
                    break;  // After each case you have to end it with a break statement,otherwise all cases will execute.
                case 2:
                    AddStudentGrade(students);
                    break;
                case 3:
                    CalculateClassAverage();
                    break;
                case 4:
                    PrintHighestGrade();
                    break;
                case 5:
                    PrintLowestGrade();
                    break;
                case 6:
                    DeleteStudent();
                    break;
                case 7:
                    StudentGrade();
                    break;
                case 8:
                    Exit();
                    break;

                default:   //Execute default case if chaoice does not match any other cases. we add no code and just put break statement which will end the switch block.
                    break;
            }
            
        }
        private static void PrintStudentGrade(List<Student> students)
        {
            string header = "Student Name           Grade";
            Console.WriteLine(header);
            Console.WriteLine(new String('-', header.Length)); // Create a new string of dashes that is the length of the header
            
            // Check if there are existing students, if so, print their grades. If not, say there are no students

            if (students != null && students.Count > 0) // || means "or". && means "and"
                //Student grade list exist in memory and contains grade 
            {
                // Print student grades
                foreach (var student in students)
                {
                    var studentFirstName = student.getFirstName();  // Get first name
                    var studentLastName = student.getLastName();     //Get last name
                    Console.WriteLine($"{studentlistnumber}")
                    var studentGradeList = student.GetGrades();     //Get student grades

                    //Print the grades if they exist if not, say no to grades 
                    Console.WriteLine(string.Empty); // Line break

                    if (studentGradeList != null && studentGradeList.Count > 0)
                    {
                        foreach (var grade in studentGradeList)
                        {
                            Console.WriteLine($"{studentFirstName} {studentLastName}        {grade}");
                        }
                    }


                }
            }

                    else
                    {
                    Console.WriteLine("There are no students in the sysytem");
            }
            

        }
        private static void AddStudentGrade(List<Student>students)
             // check for student to add grades for 

            if (students !=null students > 0) 
        {
           
         

        private static void CalculateClassAverage() 
        {
            Console.WriteLine("CalculateClassAverage method is called");
        }

        private static void PrintHighestGrade()
        {
            Console.WriteLine("PrintHighestGrades method is called");
        }
        private static void PrintLowestGrade()

        {
            Console.WriteLine("PrintLowestGrade method is called");
        }
        
        private static void DeleteStudent()
        {
            Console.WriteLine("DeleteStudent method is called");
        }

       
        private static void StudentGrade()
        {
            Console.WriteLine("StudentsGrade method is called");
        }

        private static void Exit()

        {
            
            Console.WriteLine("GoodBye!");

            exit = true; 
        }

       

    }

}
