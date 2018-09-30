// Shady Boukhary

using System;
using System.Windows.Forms;

namespace find_the_evidence
{
    /// <summary>
    /// Form for a game session. Has a ScanAnalyzer that implements
    /// the logic of the game.
    /// </summary>
    public partial class FindSampleGame : Form
    {

        /******************** Member Data ********************/

        private ScanAnalyzer scanAnalzer;
        private int found;
        private int guessCounter;

        /******************** Constructors ********************/

        public FindSampleGame()
        {
            InitializeComponent();
        }

        public FindSampleGame(int x, int y)
        {
            InitializeComponent();
            found = guessCounter = 0;
            scanAnalzer = new ScanAnalyzer(x, y, gridTextBox);
            scanAnalzer.DisplayGrid();
        }

        /******************** Methods ********************/

        private bool ValidateInput(out int row, TextBox textBox)
        {
            return Int32.TryParse(textBox.Text, out row);
        }

        private void submitGuessButton_Click(object sender, EventArgs e)
        {
            // validate input
            if (ValidateInput(out int row, rowGuessTextBox) && ValidateInput(out int column, columnGuessTextBox))
            {
                rowGuessTextBox.Text = columnGuessTextBox.Text = "";

                try
                {
                    // submit input to the scanner and evaluate
                    bool hit = scanAnalzer.EvaluateGuess(new Point(row, column));

                    // update views and counters
                    guessCounterLabel.Text = (++guessCounter).ToString();
                    guessLabel.Text = new Point(row, column).ToString();

                    if (hit)
                    {
                        hitsLabel.Text = (++found).ToString();
                        if (found == 2)
                        {
                            CompleteGame();
                        }

                    }
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show(Utilities.OUT_OF_BOUNDS_ERROR, Utilities.INPUT_ERROR);
                }
                
            } else
            {
                MessageBox.Show(Utilities.INVALID_INTEGER_ERROR, Utilities.INPUT_ERROR);
            }
        }

        private void CompleteGame()
        {
            string dialog = $"You had a total of {guessCounter} guesses. {Utilities.WIN_DIALOG}";

            // show dialog and handle result

            DialogResult result =  MessageBox.Show(dialog,
                                                   Utilities.WIN_TITLE,
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    guessCounterLabel.Text = hitsLabel.Text = "0";
                    found = guessCounter = 0;
                    scanAnalzer.ResetGrid();
                    break;
                case DialogResult.No:
                    Close();
                    break;
                default:
                    MessageBox.Show("Unknown Error", "Error");
                    break;
            }
        }

        /******************** Event Handlers ********************/

        private void exitGameButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
