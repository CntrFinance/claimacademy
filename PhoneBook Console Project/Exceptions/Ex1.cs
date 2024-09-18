using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook_Console_Project.Exceptions
{
    internal class Ex1 : Exception
    {

    
        // Default Constructor
        public Ex1()
        {

        }

        //Custom exception message for InvalidPhoneNumberException

        public Ex1(string message) : base(message)
        {

        }

        public Ex1(string message, Exception inner) : base(message, inner)
        {

        }
    
    }
}
