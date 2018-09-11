using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program_3_five_digit_number
{
    public partial class DigitDivider : Form
    {
        public DigitDivider()
        {
            InitializeComponent();
            showDigitsButton.Enabled = false;
        }

        private void showDigitsButton_Click(object sender, EventArgs e)
        {
            int num;

            if (Int32.TryParse(inputTextBox.Text, out num))
            {
                resultLabel.ForeColor = Color.Black;
                resultLabel.Font = new Font("Segoe UI", 21, FontStyle.Bold);
                resultLabel.Text = String.Format("{0}   {1}   {2}   {3}   {4}\n",
                   GetDigit(num, 10000), GetDigit(num, 1000), GetDigit(num, 100), GetDigit(num, 10), num % 10);
            } else
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                resultLabel.Text = "You did not enter a number. Try again.";
            }
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            if (inputTextBox.Text == "")
            {
                showDigitsButton.Enabled = false;
                return;
            }

            showDigitsButton.Enabled = true;
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

        private void resultLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
