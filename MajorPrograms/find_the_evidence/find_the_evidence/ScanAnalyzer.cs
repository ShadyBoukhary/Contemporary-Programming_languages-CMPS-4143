using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace find_the_evidence
{
    class ScanAnalyzer
    {
        static readonly int CLUES_NUM = 2;

        char[,] grid;
        string header;
        int guessCounter;
        int currentSample;
        TextBox gridLabel;
        Point[] clues;

        public ScanAnalyzer(int rows, int columns, TextBox gridLabel)
        {
            guessCounter = 0;
            currentSample = 0;
            this.gridLabel = gridLabel;
            InitializeHeader(columns);
            InitializeGrid(rows, columns);
            GenerateCluePositions();
        }

        void InitializeGrid(int rows, int columns)
        {
            grid = new char[rows, columns];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                {
                    grid[i, j] = '~';
                }
        }

        void InitializeHeader(int columns)
        {
            header = String.Format("  {0}", String.Join("", Enumerable.Range(0, columns)));
        }

        void GenerateCluePositions()
        {
            clues = new Point[CLUES_NUM];
            int x = grid.GetLength(0);
            int y = grid.GetLength(1);
            for (int i = 0; i < clues.Length; i++)
                clues[i] = new Point(Utilities.GetRandomInt(0, x), Utilities.GetRandomInt(0, y));
        }
        
        bool EvaluateGuess(Point guess)
        {
            guessCounter++;
            bool hit = clues[currentSample] == guess;
            char symbol = hit ? 'X' : GetSymbolAfterGuess(guess);
            grid[guess.X, guess.Y] = symbol;
            DisplayGrid();
            return hit;
        }

        char GetSymbolAfterGuess(Point guess)
        {
            if (guessCounter == 2)
                return guess.X > clues[currentSample].X ? '^' : 'v';
            else
                return guess.Y > clues[currentSample].Y ? '<' : '>';
        }

        void DisplayGrid()
        {
            string newGrid = header;
            for (int i = 0; i < grid.GetLength(0); i++)
                newGrid += String.Format("{0}  {1}", i, Utilities.GetRectArrayRow(grid, i));
            gridLabel.Text = newGrid;
        }
    }
}
