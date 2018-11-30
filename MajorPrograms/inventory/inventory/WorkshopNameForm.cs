// Shady Boukhary

using System;
using System.Linq;
using System.Windows.Forms;

namespace inventory
{
    /// <summary>
    /// Form that sets the name of a new workshop
    /// </summary>
    public partial class WorkshopNameForm : Form
    {
        /* ******************************** Constructors ******************************** */

        public WorkshopNameForm()
        {
            InitializeComponent();
        }
        /* ******************************** Properties ******************************** */

        public string WorkshopName => workshopNameTextBox.Text;

        /* ******************************** Methods ******************************** */

        /// <summary>
        /// Sets the name of the workshop to be retrieved by another form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createWorkshopButton_Click(object sender, EventArgs e)
        {
            if (workshopNameTextBox.Text.Length < 1 || !ValidName(workshopNameTextBox.Text))
                MessageBox.Show("Invalid Workshop Name. Must be longer than 1 letter and cannot contain " +
                                "special characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                Close();   
        }

        /// <summary>
        /// Makes sure name of the workshop has no special characters except whitespaces
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool ValidName(string str)
        {
            return str.Any(ch => Char.IsLetterOrDigit(ch) || Char.IsWhiteSpace(ch));
        }
    }
}
