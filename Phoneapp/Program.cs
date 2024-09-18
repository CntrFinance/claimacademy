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
using Newtonsoft.Json;
using PhoneBook_Console_Project.Exceptions; //This is the package for Json.

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
                Console.WriteLine("View phonebook directory: Select Option A. Add contact: Select Option B (A/B)");
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
            if (contactList.Count == 0)
            {

                Console.WriteLine("no contacts in phonebook memory");
                return;
            }

            Console.WriteLine("Enter first name:");
            string firstName = Console.ReadLine().ToUpper().Trim();

            Console.WriteLine("Enter last name:");
            string lastName = Console.ReadLine().ToUpper().Trim(); // Make input case-insensitive(Upper) and trim whitespaces

            bool contactFound = false;

            foreach (var contact in contactList)
            {
                if (contact.FirstName.ToUpper() == firstName && contact.LastName.ToUpper() == lastName)
                {
                    Console.WriteLine($"Contact found: {contact.FirstName} {contact.LastName} - Phone: {contact.PhoneNumber}");
                    contactFound = true;
                    break; // Exit loop once contact is found
                }
            }

            if (!contactFound)
            {
                Console.WriteLine("Contact not found.");
            }
        }


        static void DeleteContact()
        {

            try
            {
                // Check if there are contacts to delete
                if (contactList.Count == 0)
                {
                    Console.WriteLine("No contacts in phonebook to delete.");
                    return;
                }

                // Display all contacts with their index
                PrintAllContact();

                Console.WriteLine("Enter the number of the contact you want to delete (starting from 0):");
                string input = Console.ReadLine();

                // Validate input and convert to integer
                int indexToDelete;
                if (!int.TryParse(input, out indexToDelete))
                {
                    throw new FormatException("Invalid choice, must be a number.");
                }

                // Check if index is in range
                if (indexToDelete < 0 || indexToDelete >= contactList.Count)
                {
                    throw new IndexOutOfRangeException("Choice out of range.");
                }

                // Confirm deletion
                Console.WriteLine($"Are you sure you want to delete {contactList[indexToDelete].FirstName} {contactList[indexToDelete].LastName}? (Yes/No)");
                string confirmation = Console.ReadLine();

                if (confirmation.ToUpper().Trim() == "YES")
                {
                    // Delete the contact
                    string deletedContact = $"{contactList[indexToDelete].FirstName} {contactList[indexToDelete].LastName}";
                    contactList.RemoveAt(indexToDelete); // Remove contact from list
                    Console.WriteLine($"{deletedContact} has been deleted.");
                }
                else
                {
                    Console.WriteLine("Contact not deleted.");
                }
            }
                catch (FormatException)
                {
                Console.WriteLine("Invalid choice, try again.");
                }
                catch (IndexOutOfRangeException)
                {
                Console.WriteLine("Choice out of range, try again.");
                }
            
                catch (Exception Ex1)
                {
                Console.WriteLine($"Error.{Ex1.Message}");

                }
        
            
        }
        static void PrintAllContact()
        {
            if (contactList != null && contactList.Any())
            {


               foreach (Contact contact in contactList)
               {
                    Console.WriteLine($"Name: {contact.FirstName} {contact.LastName}, Phone: {contact.PhoneNumber}");
               }


            }


        }
        static void SaveContact()
        {
            // Define folder path and file name to save transactions JSON
            string folderPath = "C:\\Users\\Owner\\Documents"; // make sure to add 2 \\ when copying file path from the file explorer.
            string fileName = "SavedContacts.json";

            // Build a full file path for the transactions
            string path = Path.Combine(folderPath, fileName);

            // Make JSON out of the transactions
            string json = JsonConvert.SerializeObject(Contact);

            // Save the JSON to a file
            File.WriteAllText(path, json);

            // Notify user of successful save and save location
            Console.WriteLine($"\nStudents saved to {path}.");


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
            
            Console.WriteLine($"Contact {firstName.ToUpper().Trim()} {lastName.ToUpper().Trim()} added successfully. The phone is {phoneNumber}");

            PrintAllContact();

            contactList.Add
                (
                    new Contact
                    { 
                        FirstName = firstName,
                        LastName = lastName,
                        PhoneNumber = phoneNumber
                    
                    }
                
                
                );

            

            //int - up to 10 digits -  -2,147,483,648 to 2,147,483,6471. 
            //long - can accommodate 19 digits -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
        }
        static void Exit() //This work 100%
        {
            Console.WriteLine("Good-Bye! Press any key to exit.");
            Console.ReadKey(); 
            exit = true;
        }


    }
}

