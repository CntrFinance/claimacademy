using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeMananger
{
    public class Student
    {
        private string _firstName { get; set; } //Private Fields should start with an underscore, the underscore to identify private or public data for orginization
        private string _lastName { get; set; }
        
        private double _average { get; set; }
        //Constructor: See Constructor Section in week 1 code for more info
        private List<int> _grades { get; set; } 

        public Student()
        {

        }



        public Student(string firstName, string lastName)
        {
            //Parameterized constructor, accepts arguments as parameters (in this case 2 string )

            _firstName = firstName;
            _lastName = lastName;   
        }

        //Getters and setters
        //Setter methods can be void as no return value is needed.
        //we will not use the static 
        public void setFirstName(string firstName) //Parameter for set, because we are passing this dat into the method.
        { 
            _firstName = firstName;
        }

        public string getFirstName() // Return private _firstname value via public accessor method.return type "string" needed as we are returning the string value in _firstName.
        {                            // No parameter here because we are insteas returning dataa from the method rather than passing data into the method.
            return _firstName;       //return statement sends this data out of the method when this method is called. typically you can can assign to a string variable method called like you would a value.
                                    //
        }

        public string getLastName() 
        {
            return _lastName;   
        }
        public void AddGrade(int grades)
        {
            _grades.Add(grades);
        }

        public double GetAverage()
        {
            double average = 0; // Defalut average to 0

            double totalPoints = 0;
            // compute average
            foreach (int grade in _grades) 
            {
                totalPoints += grade;
            }
             int gradecount = _grades.Count;

            average = totalPoints / gradecount; 
            return average; 
            {
                
                
                    
                   
                       
                
            }

        }

       







    }


}