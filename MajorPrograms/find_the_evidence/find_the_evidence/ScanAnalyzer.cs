// Shady Boukhary

using System;
using System.Linq;
using System.Windows.Forms;

namespace find_the_evidence
{
    /// <summary>
    /// Implements main logic of the game. Evaluates guesses, updates grid,
    /// generates locations for clues.
    /// </summary>
    class ScanAnalyzer
    {
        /******************** Member Data ********************/

        static readonly int CLUES_NUM = 2;
        private char[,] grid;
        private string header;
        private int guessCounter;
        private int currentSample;
        private TextBox gridTextBox;
        private Point[] clues;

        /******************** Constructos ********************/

        public ScanAnalyzer(int rows, int columns, TextBox gridTextBox)
        {
            guessCounter = 0;
            currentSample = 0;
            this.gridTextBox = gridTextBox;
            InitializeHeader(columns);
            InitializeGrid(rows, columns);
            GenerateCluePositions();
        }

        /******************** Private Methods ********************/

        /// <summary>
        /// Initializes the grid to '~' values
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        private void InitializeGrid(int rows, int columns)
        {
            grid = new char[rows, columns];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                {
                    grid[i, j] = '~';
                }
        }

        /// <summary>
        /// Initializes the header containing the columns of the grid
        /// </summary>
        /// <param name="columns"></param>
        private void InitializeHeader(int columns)
        {
            header = $"   {String.Join("", Enumerable.Range(0, columns))}{Environment.NewLine}";
        }

        /// <summary>
        /// Generates random positions for the clues.
        /// </summary>
        private void GenerateCluePositions()
        {
            clues = new Point[CLUES_NUM];
            int x = grid.GetLength(0);
            int y = grid.GetLength(1);

            for (int i = 0; i < clues.Length; i++)
                clues[i] = new Point(Utilities.GetRandomInt(0, x), Utilities.GetRandomInt(0, y));

            Console.WriteLine(clues[0].ToString());
            Console.WriteLine(clues[1].ToString());
        }

        /// <summary>
        /// Is called when a guess is a miss. Finds the appropriate symbol 
        /// for the clue.
        /// </summary>
        /// <param name="guess"></param>
        /// <returns>Symbol for the clue</returns>
        private char GetClueHint(Point guess)
        {
            if (guessCounter % 2 == 0)
                return guess.X > clues[currentSample].X ? '^' : 'v';
            else
                return guess.Y > clues[currentSample].Y ? '<' : '>';
        }

        /******************** Public Methods ********************/

        /// <summary>
        /// Checks if the guess matches the location of a clue. If yes,
        /// update counters. Updates the grid with the correct symbol
        /// and calls DisplayGrid().
        /// </summary>
        /// <param name="guess"></param>
        /// <returns></returns>
        public bool EvaluateGuess(Point guess)
        {
            guessCounter++;
            bool hit = clues[currentSample] == guess;

            if (hit)
            {
                currentSample++;
                grid[guess.X, guess.Y] = 'X';

                if (currentSample < 2)
                {
                    DisplayGrid();
                    MessageBox.Show(Utilities.CLUE_FOUND_DIALOG, Utilities.CLUE_FOUND_TITLE);
                }
                
                RemoveGridHints();
            } 
            else
            {
                grid[guess.X, guess.Y] = GetClueHint(guess);
            }

            DisplayGrid();
            return hit;
        }

        /// <summary>
        /// Displays the grid to a TextBox and formats it correctly.
        /// </summary>
        public void DisplayGrid()
        {
            string newGrid = header;
            for (int i = 0; i < grid.GetLength(0); i++)

                newGrid += $"{i}  {Utilities.GetRectArrayRow(grid, i)}{Environment.NewLine}";

            gridTextBox.Text = newGrid;
        }

        /// <summary>
        /// Resets the grid after all clues have been found.
        /// </summary>
        public void ResetGrid()
        {
            currentSample = 0;
            InitializeGrid(grid.GetLength(0), grid.GetLength(1));
            GenerateCluePositions();
            DisplayGrid();
        }

        /// <summary>
        /// Removes all hints from a grid when 1 clue has been found and
        /// the game is not over yet.
        /// </summary>
        public void RemoveGridHints()
        {
            for (int i = 0; i < grid.GetLength(0); i++)
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] != 'X')
                    {
                        grid[i, j] = '~';
                    }
                }     
        }
    }
}
