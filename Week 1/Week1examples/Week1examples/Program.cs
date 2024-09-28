using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y = 2147483647;  //int	4 bytes	Stores whole numbers from -2,147,483,648 to 2,147,483,647

            long x = 9223372036854775807L; //long	8 bytes	Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            
            float p = 0.1234567F; //Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
            
            double o = 0.123456789012345D; //Stores fractional numbers. Sufficient for storing 15 decimal digits

            bool f = false;

            bool k = true;

            char c = 'A';

            string s = "We are learning C#";

            int[] numbers = {1, 2, 3, 4, 5};
            double[] doubleNumbers = {1.12, 2.12, 3.12, 4.12 };
            string[] names = {"Jibreel", "Jarvis", "Tavish", "Greg"}; // We created a string array[] called names 

            for (int i = 1923; i <= 1999; i++) 
            {
                Console.WriteLine("Iteration number: " + i );

            }

            Console.WriteLine();

            foreach (int number in numbers)
            {
                Console.WriteLine("Numbers" + number);
            }

            Console.WriteLine();

            foreach (string name in names) // We created a string array[] called names this goes into the array to extract the data inside of our array.
            {
                Console.WriteLine("Here are the names: "+ name); // This will display the names in our names array.
            }
            Console.WriteLine();

            Console.WriteLine($"This is a int:{Environment.NewLine}" + y);
            Console.WriteLine();

            Console.WriteLine($"This is a long:{Environment.NewLine}" + x);
            Console.WriteLine();

            Console.WriteLine($"This is a float:{Environment.NewLine}" + p);
            Console.WriteLine();

            Console.WriteLine($"This is a double:{Environment.NewLine}" + o);
            Console.WriteLine();


            Console.WriteLine();

            string numberString = "123";
            int numberOne = Convert.ToInt32(numberString);
            Console.WriteLine(numberOne); // Outputs: 123

            string doubleString = "3.14";
            double pi = Convert.ToDouble(doubleString);
            Console.WriteLine(pi); // Outputs: 3.14

            string boolString = "True";
            bool value = Convert.ToBoolean(boolString);
            Console.WriteLine(value); // Outputs: True

            object nullValue = null;
            int defaultValue = Convert.ToInt32(nullValue);
            Console.WriteLine(defaultValue); // Outputs: 0

            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(s);
            Console.ReadLine();

            Console.WriteLine();

        }

    }
}
