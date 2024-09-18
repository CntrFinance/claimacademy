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
                Console.WriteLine("View phonebook directory: Select Option A. Add contactList: Select Option B (A/B)");
                string option = Console.ReadLine();

                if (option.ToUpper().Trim() == "A")
                {
                    PhoneBookDirectory();
                }

                if ( option.ToUpper().Trim() == "B")
                {
                    AddNewContact();
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
            Console.Write("Find a contactList by name:");
        }
        static void DeleteContact()
        {
            PrintAllContact();
            Console.WriteLine("What contactList would you like to delete?");

            //contactList.Remove();
            Console.Write(" ");

           // foreach (var contactList in Contact)
            {

            }

            Console.WriteLine("Are you sure you want to delete this contactList. (Yes/No)");
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
            //  string contactsJsonFile = JsonSerializer.Serialize(contactList);
            //   var path = "C:\\Users\\Owner\\source\\claimacademy\\PhoneBook Console Project";
            //   File.WriteAllText(path, contactJson);
            //   Console.WriteLine($"\nStudents saved to {path}.");


        }
        static void AddNewContact()
        {

            Console.WriteLine($"What is the name of the contactList you want to add? Please type first and last name.{Environment.NewLine}");
            Console.WriteLine($"Enter First Name:{Environment.NewLine}");//Console.WriteLine breaks to the next line, Console.Write Puts all strings on the same line.
            string firstName = Console.ReadLine();

            Console.WriteLine($"Enter Contacts Last Name:{Environment.NewLine}");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Enter Phone Number:{Environment.NewLine}");
            long phoneNum = long.Parse(Console.ReadLine());
            string phoneNumber = string.Concat("+", phoneNum);

            contactList.Add
                (
                    new Contact
                    { 
                        FirstName = firstName,
                        LastName = lastName,
                        PhoneNumber = phoneNumber
                    
                    }
                
                
                );

            Console.WriteLine($"Contact {firstName} {lastName} added successfully.");
            PrintAllContact();

            //int - up to 10 digits -  -2,147,483,648 to 2,147,483,6471. 
            //long - can accommodate 19 digits -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
        }
        static void Exit()
        {
            Console.WriteLine("Exiting PhoneBook...");
            exit = true;
        }


    }
}

