/* Shady Boukhary
 * CMPS 4143: Contemporary Programming Languages
 * September 5th, 2018
 * Dr. Stringfellow
 * Description: A simple program that reads a 5-digit integer from the console, 
 * then displays its digits separately. The program assumes valid input.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five_digit_number
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;

            while (run)
            {
                Console.Write("Enter a 5-digit number: ");
                int num = ReadInteger();

                Console.WriteLine(String.Format("Digits: {0}   {1}   {2}   {3}   {4}\n",
                   GetDigit(num, 10000), GetDigit(num, 1000), GetDigit(num, 100), GetDigit(num, 10), num % 10));

                Console.Write("Run again? (Y/N): ");

                if (Console.ReadLine().ToUpper() == "N")
                {
                    run = false;
                } 

            }
        }

        /// <summary>
        /// Finds a digit in an integer
        /// </summary>
        /// <param name="num"></param>
        /// <param name="div"></param>
        /// <returns></returns>
        public static int GetDigit(int num, int div)
        {
            return num / div % 10;
        }

        /// <summary>
        /// Reads an integer from the console and validates it.
        /// </summary>
        /// <returns>Returns an integer</returns>
        public static int ReadInteger()
        {
            int x;
            String res = Console.ReadLine();

            while (!Int32.TryParse(res, out x) || res.Length > 5)
            {
                Console.WriteLine("Not a valid integer or integer is longer than 5 digits. Try again.");
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
                "Welcome to Five Digit Integer Program\n\n");
        }
    }
}
