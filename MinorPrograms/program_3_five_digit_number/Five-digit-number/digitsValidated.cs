/* Shady Boukhary
 * CMPS 4143: Contemporary Programming Languages
 * September 5th, 2018
 * Dr. Stringfellow
 * Description: A simple program that reads an integer from the console, 
 * then displays its digits separately.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveDigitsValidated
{
    class digitsValidated
    {
        static void Main(string[] args)
        {
            bool run = true;
        
            PrintHeader();
      
            while (run)
            {
                Console.Write("Enter a number: ");
                int num = ReadInteger();

                foreach(int x in GetDigits(num))
                {
                    Console.Write(String.Format("{0}   ", x));
                }

                Console.Write("\nRun again? (Y/N): ");

                if (Console.ReadLine().ToUpper() == "N")
                {
                    run = false;
                }

            }
        }

        /// <summary>
        /// Gets digits in an integer
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Array of the digits</returns>
        public static int[] GetDigits(int num)
        {
            int[] digits = new int[num.ToString().Length];
            for (int x = 0; x < digits.Length; x++)
            {
                digits[x] = num % 10;
                num = num / 10;
            }
            Array.Reverse(digits);
            return digits;
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
                Console.WriteLine("Not a valid integer or is longer than 5 digits. Try again.");
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
