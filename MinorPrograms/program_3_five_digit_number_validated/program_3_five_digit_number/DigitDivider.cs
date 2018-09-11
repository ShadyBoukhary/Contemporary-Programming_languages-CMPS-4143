/* Shady Boukhary
 * CMPS 4143: Contemporary Programming Languages
 * Program 3 Extra Credit
 * September 12th, 2018
 * Dr. Stringfellow
 * Description: GUI App - The user enters an integer then its digits are displayed seperately.
*/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace program_3_five_digit_number_validated
{
    public partial class DigitDivider : Form
    {
        public DigitDivider()
        {
            InitializeComponent();
            showDigitsButton.Enabled = false;
        }

        /* Event Handlers */

        private void showDigitsButton_Click(object sender, EventArgs e)
        {
            int num;

            if (Int32.TryParse(inputTextBox.Text, out num) && inputTextBox.Text.Length < 6)
            {
                resultLabel.ForeColor = Color.Black;
                resultLabel.Font = new Font("Segoe UI", 21, FontStyle.Bold);
                resultLabel.Text = "";
                foreach(int x in GetDigits(num))
                {
                    resultLabel.Text += String.Format("{0}   ", x);
                }
            } else
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                resultLabel.Text = "Input must be a 5-digit-or-less number. Try again.";
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
    }
}
