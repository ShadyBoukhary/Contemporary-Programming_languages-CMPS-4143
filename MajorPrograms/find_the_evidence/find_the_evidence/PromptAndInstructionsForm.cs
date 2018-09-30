/* Shady Boukhary
 * CMPS 4143: Contemporary Programming Languages
 * Program 4
 * October 1st, 2018
 * Dr. Stringfellow
 * 
 * Description: A simple puzzle game where the player searches for 2 samples 
 * inside a grid of a size of the player's choosing. The player enters the coordinates
 * of the samples by guessing. Then, the grid is updated with clues as to where
 * the samples are located. This process is repeated until the player has successfully
 * found the two samples or decides to give up.
*/

using System;
using System.Windows.Forms;

namespace find_the_evidence
{
    /// <summary>
    /// Form that prompts the user to customize the game,
    /// shows instructions, and starts a game.
    /// </summary>
    public partial class PromptAndInstructionsForm : Form
    {
        /******************** Member Data ********************/

        private bool randomGame;

        /******************** Constructors ********************/

        public PromptAndInstructionsForm()
        {
            InitializeComponent();
            randomGame = false;
            instructionsLabel.Text = Utilities.INSTRUCTIONS;
        }

        /******************** Event Handlers ********************/

        private void rowSlider_Scroll(object sender, EventArgs e)
        {
            rowSizeIndicatorLabel.Text = rowSlider.Value.ToString();
        }

        private void columnSlider_Scroll(object sender, EventArgs e)
        {
            columnSizeIndicatorLabel.Text = columnSlider.Value.ToString();
        }

        private void randomCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            randomGame = !randomGame;
            rowSlider.Enabled = columnSlider.Enabled = !randomGame;
        }

        /// <summary>
        /// Event handler that starts a new game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButton_Click(object sender, EventArgs e)
        {
            FindSampleGame game;
            if (randomGame)
            {
                // generate random grid size and instantiate a new Form
                Point row = new Point(rowSlider.Minimum, rowSlider.Maximum);
                Point column = new Point(columnSlider.Minimum, columnSlider.Maximum);

                game = new FindSampleGame(Utilities.GetRandomInt(row.X, row.Y),
                                          Utilities.GetRandomInt(column.X, column.Y));
            }
            else
            {
                game = new FindSampleGame(rowSlider.Value, columnSlider.Value);
            }

            Hide();
            // add event listener
            game.FormClosed += new FormClosedEventHandler(findSampleGame_FormClosed);
            game.Show();
        }

        void findSampleGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        } 
    }
}
