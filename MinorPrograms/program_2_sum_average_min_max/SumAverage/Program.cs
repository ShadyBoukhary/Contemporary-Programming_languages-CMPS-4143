/* Shady Boukhary
 * CMPS 4143: Contemporary Programming Languages
 * September 5th, 2018
 * Dr. Stringfellow
 * Description: A simple program that reads 3 integers from the console,
 * finds the sum, the average, the minimum, and maximim of the integers.
 * Finally, it dumps that information to the console.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[3];
            String[] labels = { "1st", "2nd", "3rd" };

            PrintHeader();

            // Read integers from console
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(String.Format("Please enter the {0} integer: ", labels[i]));
                nums[i] = ReadInteger();
            }

            // Print the sum, average, min, and max of the integers
            Console.WriteLine(String.Format(
                "\nThe sum is {0}.\n" +
                "The average is {1}.\n" +
                "The smallest number is {2}.\n" +
                "The largest number is {3}. ", nums.Sum(), (int)nums.Average(), nums.Min(), nums.Max()));
            Console.ReadKey();

        }
        /// <summary>
        /// Reads an integer from the console and validates it.
        /// </summary>
        /// <returns>Returns an integer</returns>
        public static int ReadInteger()
        {
            int x;
            String res = Console.ReadLine();

            while (!Int32.TryParse(res, out x))
            {
                Console.WriteLine("Not a valid integer. Try again.");
                res = Console.ReadLine();
            }
            return x;
        }

        /// <summary>
        /// Prints information about the program.
        /// </summary>
        public static void PrintHeader()
        {
            Console.WriteLine("Shady Boukhary\n" +
                "Dr. StringFellow\n" + 
                "September 5th, 2018\n" +
                "CMPS 4143: Contemporary Programming Languages\n" + 
                "Welcome to Integer Adder\n\n");
        }
    }
}
