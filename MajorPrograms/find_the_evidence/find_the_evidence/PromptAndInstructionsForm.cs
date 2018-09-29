using System;
using System.Windows.Forms;

namespace find_the_evidence
{
    public partial class PromptAndInstructionsForm : Form
    {
        bool randomGame;

        public PromptAndInstructionsForm()
        {
            InitializeComponent();
            randomGame = false;
            instructionsLabel.Text = "Instructions\n" +
                "Search for clues to solve a murder mystery. You will be presented " +
                "with a grid of a size of your choosing or a random one. You must enter " +
                "coordinates in order to find the clues in the grid. If the coordinates don't match," +
                " the game will give you a hint as to where the clues are located. Continue " +
                "searching until both clues have been found.";
        }

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

        private void playButton_Click(object sender, EventArgs e)
        {

        }
    }
}
