using System;

namespace find_the_evidence
{
    class Utilities
    {
        private static readonly int charSize = 2; 

        /// <summary>
        /// Gets a random integer
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int GetRandomInt(int min, int max)
        {
            return new Random(DateTime.Now.Millisecond).Next(min, max);
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
                Console.WriteLine("ERROR: {0}", exception.Message);
            }

            return new string(target);
        }


    }
}
