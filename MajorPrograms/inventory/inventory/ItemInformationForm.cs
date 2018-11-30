// Shady Boukhary

using System;
using System.Windows.Forms;

namespace inventory
{
    /// <summary>
    /// Form that allows the user to insert or update an item in the item list of the workshop
    /// </summary>
    public partial class ItemInformationForm : Form
    {
        /* ******************************** Constructors ******************************** */

        public ItemInformationForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Parameterized Constructor for updating an item
        /// </summary>
        /// <param name="record"></param>
        public ItemInformationForm(Record record)
        {
            InitializeComponent();
            Record = record;
            nameTextBox.Text = Record.Name;
            priceTextBox.Text = Record.Price.ToString();
            quantityTextBox.Text = Record.Quantity.ToString();
            addItemButton.Text = "Update Item";
        }

        /* ******************************** Properties ******************************** */

        public Record Record { get; private set; }

        /* ******************************** Methods ******************************** */


        /// <summary>
        /// Adds a new item
        /// </summary>
        private void AddItem()
        {
            try
            {
                string name = nameTextBox.Text;

                if (name == "")
                    throw new Exception();

                double price = double.Parse(priceTextBox.Text);
                int quantity = int.Parse(quantityTextBox.Text);

                Record = new Record(name, price, quantity);
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input. Try again.", "Error");
            }
        }

        /// <summary>
        /// Handle button clicks - both add and cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttons_Click(object sender, EventArgs e)
        {
            if (sender == addItemButton)
                AddItem();

            else
                Close();
        }
    }
}
