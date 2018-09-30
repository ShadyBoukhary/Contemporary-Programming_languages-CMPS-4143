// Shady Boukhary

using System;
namespace find_the_evidence
{
    /// <summary>
    /// Utility class with general methods and constants
    /// </summary>
    class Utilities
    {
        /******************** Member Data ********************/

        private static readonly int charSize = 2;
        private static readonly Random rand = new Random(DateTime.Now.Millisecond);

        /******************** Properties ********************/

        public static string INPUT_ERROR
        {
            get
            {
                return "Input Error";
            }
        }

        public static string OUT_OF_BOUNDS_ERROR
        {
            get
            {
                return "Coordinates entered must be within the size of the grid.";
            }
        }

        public static string INVALID_INTEGER_ERROR
        {
            get
            {
                return "You did not enter a valid integer.";
            }
        }

        public static string INSTRUCTIONS
        {
            get
            {
                return "Instructions\n" +
                "Search for clues to solve a murder mystery. You will be presented " +
                "with a grid of a size of your choosing or a random one. You must enter " +
                "coordinates in order to find the clues in the grid. If the coordinates don't match," +
                " the game will give you a hint as to where the clues are located. Continue " +
                "searching until both clues have been found.";
            }
        }

        public static string WIN_TITLE
        {
            get
            {
                return "SUCCESS!";
            }
        }

        public static string WIN_DIALOG
        {
            get
            {
                return "Would you like to restart the game?";
            }
        }

        public static string CLUE_FOUND_TITLE
        {
            get
            {
                return "Clue found!";
            }
        }

        public static string CLUE_FOUND_DIALOG
        {
            get
            {
                return "Press OK to search for the next clue.";
            }
        }

        /******************** Methods ********************/

        /// <summary>
        /// Gets a random integer
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int GetRandomInt(int min, int max)
        {
            return rand.Next(min, max);
        }

        /// <summary>
        /// Gets the row of a char matrix as a string
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="row"></param>
        /// <returns>string</returns>
        public static string GetRectArrayRow(char[,] matrix, int row)
        {
            int size = matrix.GetLength(1);
            char[] target = new char[matrix.GetLength(1)];
            try
            {
                Buffer.BlockCopy(matrix, size * charSize * row, target, 0, charSize * size);
            }
            catch (Exception exception)
            {
                Console.WriteLine($"ERROR: {exception.Message}");
                throw exception;
            }

            return new string(target);
        }
    }
}
