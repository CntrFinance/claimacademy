using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook_Console_Project.Exceptions
{
    internal class InvalidPhoneNumberException : Exception
    {
        // Default Constructor
        public InvalidPhoneNumberException() 
        {
        
        }

        //Custom exception message for InvalidPhoneNumberException

        public InvalidPhoneNumberException(string message) : base(message)
        {
        
        }

        public InvalidPhoneNumberException(string message, Exception inner) : base(message, inner)
        {
        }

    }
}
