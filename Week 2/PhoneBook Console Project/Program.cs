using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json; //This is the package for Json.

namespace PhoneBook_Console_Project
{
    internal class Program
    {

        static bool exit;
        static List<Contact> contactList= new List<Contact>(); // this creates a empty List.
        static int numOfContacts;
        static int Contact;
        const string filePath = "contacts.json";

        static void Main(string[] args)
        {
            
            

            try
            {
                // numOfContacts = 0;

                exit = false;

                Console.WriteLine("PhoneBook");
                Console.WriteLine($"-------------{Environment.NewLine}");

                Console.WriteLine($"Do you want to add a new contact? Yes or NO?{Environment.NewLine}");
                string option1 = Console.ReadLine();

                Console.WriteLine($"{Environment.NewLine}");

                Console.WriteLine($"To view phonebook directory: Select Option A.{Environment.NewLine}");
                string option = Console.ReadLine();

                

                if (option.ToUpper().Trim() == "A")
                {
                    PhoneBookDirectory();
                }

                if ( option1.ToUpper().Trim() == "Yes")
                {
                    AddNewContact();
                };

                if (option1.ToUpper().Trim() == "NO")
                {
                    PhoneBookDirectory();
                };


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error.{ ex.Message}");

            }

        }
        static void PhoneBookDirectory()
        {
            while (!exit)
            {
                Console.WriteLine($"{Environment.NewLine}Select an option: {Environment.NewLine}");
                Console.WriteLine("1. Search for contact.");
                Console.WriteLine("2. Delete contact.");
                Console.WriteLine("3. Print all contacts.");
                Console.WriteLine("4. Save contact to file");
                Console.WriteLine("5. Add new a contact.");
                Console.WriteLine($"6. Exit{Environment.NewLine}");

                int choice = int.Parse(Console.ReadLine());  // Capture option choice from user input.

                switch (choice)
                {
                    case 1:
                        SearchContact();
                        break;
                    case 2:
                        DeleteContact();
                        break;
                    case 3:
                        PrintAllContact();
                        break;
                    case 4:
                        SaveContact();
                        break;
                    case 5:
                        AddNewContact();
                        break;
                    case 6:
                        Exit();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select an option from the menu.");
                        break;

                }

            }

        }

        static void SearchContact()
        {
            Console.WriteLine("Find Contact:");


            Console.WriteLine($"Enter first name{Environment.NewLine}");
            string firstName = Console.ReadLine().Trim().ToUpper();


            Console.WriteLine($"Enter last name{Environment.NewLine}");
            string lastName = Console.ReadLine().Trim().ToUpper();

            foreach(var contact in contactList)
            {

                if(contact.FirstName.Trim().ToUpper().Equals(firstName) && contact.LastName.Trim().ToUpper().Equals(lastName))
                {
                   Console.WriteLine($"Contact Found{Environment.NewLine}");
                   Console.WriteLine($"Contact First Name {contact.FirstName}");
                   Console.WriteLine($"Contact Last Name {contact.LastName}");
                   Console.WriteLine($"Phone Number {contact.PhoneNumber}");
                   Console.WriteLine("Have a great day");
                    return; // this is a statement that terminates an entire method, in this case it is returning us to the Phonebook directory. 
                }    

            }
            Console.WriteLine("Contact not found.");

          
        }


        static void DeleteContact()
        {
            PrintAllContact();
            Console.WriteLine("What contact would you like to delete?");

            //contactList.Remove();
            Console.Write(" ");

           // foreach (var contactList in Contact)
            {

            }

            Console.WriteLine("Are you sure you want to delete this contact. (Yes/No)");
            string option = Console.ReadLine();

            if (option.ToUpper().Trim() == "Yes")
            {
                Console.WriteLine("Contact Deleted");
            }

                
        }
        static void PrintAllContact()
        {
            if (contactList != null && contactList.Any());
            {


               foreach (Contact contact in contactList)
                {
                    Console.WriteLine($"Name: {contact.FirstName} {contact.LastName}, Phone: {contact.PhoneNumber}");
                }


            }


        }

        static void SaveContact()
        {
            string directory = "C:\\Users\\Owner\\Documents";

            string filename = "contactlist.json";

            string path = Path.Combine(directory, filename);

            var json = JsonConvert.SerializeObject(contactList, Formatting.Indented);   
            
            Console.WriteLine($"\nStudents saved to {path}.");


        }

        static void AddNewContact()
        {

            Console.WriteLine($"What is the name of the contact you want to add? Please type first and last name.{Environment.NewLine}");
            Console.WriteLine($"Enter First Name:{Environment.NewLine}");//Console.WriteLine breaks to the next line, Console.Write Puts all strings on the same line.
            string firstName = Console.ReadLine();
            Console.WriteLine($"{Environment.NewLine}");

            Console.WriteLine($"Enter Contacts Last Name:{Environment.NewLine}");
            string lastName = Console.ReadLine();
            Console.WriteLine($"{Environment.NewLine}");

            Console.WriteLine("Country Code: ");
            string countryCode = Console.ReadLine();
            Console.WriteLine($"{Environment.NewLine}");

            Console.WriteLine($"Enter Phone Number:{Environment.NewLine}");
            long phoneNum = long.Parse(Console.ReadLine());
            string phoneNumber = string.Concat("+", countryCode, phoneNum);
            Console.WriteLine($"{Environment.NewLine}");

            contactList.Add
                (
                    new Contact
                    { 
                        FirstName = firstName,
                        LastName = lastName,
                        PhoneNumber = phoneNumber,
                        CountryCode = countryCode
                    
                    }
                
                
                );

            Console.WriteLine($"Contact {firstName} {lastName} {phoneNumber} added successfully.");

            Console.ReadLine();

            PrintAllContact();

            Console.ReadLine();
            
            //int - up to 10 digits -  -2,147,483,648 to 2,147,483,6471. 
            //long - can accommodate 19 digits -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
        }

        static void Exit()
        {
            Console.WriteLine("Exiting PhoneBook...");

            Console.ReadLine();

            exit = true;
        }


    }
}

