using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1examples
{
    public class Student //Creating a Student class with attributes such as: Color, First Name, Height, Last Name, and Gender.
    {
        public double height;

        public string skinColor;
        public string firstName;
        public string size;
        public string lastName;
        public string gender;

        public Student(string skinColor, string firstName, double height, string lastName, string gender, string size) // Constructor this allows us to assign a value to an object. We initialized our objects when passed through (). 

        {
            // skinColor = "Brown"; // the skinColor string object is assigned a value, that is set to a string, which is "Brown".
            this.skinColor = skinColor;
            this.firstName = firstName;
            this.height = height;  
            this.lastName = lastName;
            this.gender = gender;
            this.size = size;
            
        }

        public void StudentInfo()
        {
            Console.WriteLine($"Student: {firstName} {lastName}, is a: {gender}, with the skin color: {skinColor}, height: {height}. Size: {size}.");
        }
    }

}
