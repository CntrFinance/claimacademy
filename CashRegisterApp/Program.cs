using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CashRegisterApp
{
    internal class Program
    {
        //1. You cannot give more change than is available in the drawer
        //2. Bills greater than $100 cannot be accepted
        //3. You will need to make a sale, and then type in the charge for the sale
        //4. You will then input how much cash customer gives, if the cash is more than the charge, you need to give the difference in change
        //5. You need to keep track of the balance as you make sales and give change when change is due.

        //Use the static modifier to declare a static member, which belongs to the type itself rather than to a specific object.
        //The static modifier can be used to declare static classes. 

        static double withdrawbalance;
        // withdrawBalance is the balance of the withdrawal, this is to be set as sbalance because we have to as the bank withdrawal 

        static double endingbalance = 0;
        // end of the day balance, this 

        static List<TransactionRecord> transactionData;

        
        //Environment.NewLine Will properly add the windows environment.
        static void Main(string[] args)
        {

            // Initialize the transactionData list only once
            transactionData = new List<TransactionRecord>();

            // Set Starting balance 
            Console.Write("Enter this mornings withdrawal balance:$");
            double withdrawBalance = double.Parse(Console.ReadLine());

            Thread.Sleep(1000);

            // Display Starting balance 
            Console.WriteLine($"Starting balance of cash register is:${withdrawBalance}");

            Console.ReadLine();

            while (true) {

                //Disp
                Console.WriteLine("\nCurrent Balance: $" + withdrawBalance);
                Console.Write("Enter the sale amount:$ ");
                decimal saleAmount = decimal.Parse(Console.ReadLine());


                if (saleAmount >= 101)
                {
                    Console.WriteLine("Sale amount must be less than $100.");
                    
                    continue;
                }
                //Determine if we have enough cash in the cash draw

                //cashGiven = 
                Console.Write("Enter the cash given by the customer:$");
                decimal cashGiven = decimal.Parse(Console.ReadLine());

                decimal change = saleAmount- cashGiven; //Console.WriteLine("$$cashGiven - saleAmount");

                if (change >= 101)
                {
                    Console.WriteLine("We cannot complete this transaction.");

                }

               else 
                {
                    Console.WriteLine("Remaining Amount Owed is $" + change + ". We accept, Cash, Credit, and Crypto! Please pay now!");
                }


                //Before we think about saving the transaction history to TransactionRecord class we need to fully complete our transaction
                //Process so that we can know what variable to store in our list, this should account for money coming in and going out
                //Transaction should only have information unique to that transaction
                // add keyword - Search up this for list in C#
                // Add Method this is apart of the lsit class.

                transactionData.Add(new TransactionRecord(saleAmount, change, cashGiven));

                withdrawbalance -= (double)change;
                    
                        
                //So we have to create a list for this example because an array only uses preset variables.
                //Look at tuple option for the different variables in the transaction.
                
                //Console.Write("Enter in cash Denominations.($1, $5, $10, $20, $50, $100)."); I want to import a list for the that calculates the Cash denominations 

                // if (customerdenomination <= 100) 
                
            }
        }
    }
}
//1. Greet the customer
//Console.WriteLine("Welcome to the Accountabul, a virtual cash register app!");

//Give customer total on item purchased

//3. Input how much money the customer has given you. This step will need to have that bills over $100 aren't accepted. 
//Example if CustomerDenomination is > 100, then Console.Writeline = "Denomination not accepted. Wait for Cashier!"