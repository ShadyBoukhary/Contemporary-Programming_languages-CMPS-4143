// Shady Boukhary

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace inventory
{
    /// <summary>
    /// Form that shows workshop details, including supplies
    /// </summary>
    public partial class WorkshopForm : Form
    {
        /* ******************************** Member Data ******************************** */

        private string path;
        private string name;
        private FileStream fileStream;
        private BinaryFormatter serializer;
        private List<Record> records;   // for easy serialized and reduced string processing

        /* ******************************** Constructors ******************************** */

        public WorkshopForm(string path, string name)
        {
            InitializeComponent();
            this.path = path;
            this.name = name;
            fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            serializer = new BinaryFormatter();
            records = new List<Record>();
        }

        /* ******************************** Methods ******************************** */

        /// <summary>
        /// OnLoad event, loads workshop data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WorkshopForm_Load(object sender, EventArgs e)
        {
            string col1 = "ITEM NAME", col2 = "PRICE", col3 = "QUANTITY";

            // set header
            workshopItemsListBox.Items.Add($"{col1.PadRight(30 - col1.Length)}\t" +
                $"{col2.ToString().PadLeft(31 - col2.ToString().Length)}" +
                $"\t\t{col3.ToString().PadLeft(28 - col3.ToString().Length)}");

            // set menu item states
            ((MainMenuForm)MdiParent).ToggleInsert(true);
            ((MainMenuForm)MdiParent).ToggleSave(true);

            LoadWorkshop();
        }

        /// <summary>
        /// Loads all workshop data from file
        /// </summary>
        private void LoadWorkshop()
        {
            try
            {
                while (true)
                {
                    // deserialize data and add to lists, update GUI
                    Record record = (Record)serializer.Deserialize(fileStream);
                    workshopItemsListBox.Items.Add(record);
                    records.Add(record);
                }
            }
            catch (SerializationException)
            {
                fileStream.Close();
            }

            // update GUI labels
            numberOfItemsLabel.Text = $"There are {workshopItemsListBox.Items.Count - 1} items in this workshop";
            workshopNameLabel.Text = $"Workshop: {name}";
        }

        /// <summary>
        /// Inserts a new Record to the workshop
        /// </summary>
        public void InsertItem()
        {
            // get record information from ItemInformationForm
            ItemInformationForm form = new ItemInformationForm();
            form.ShowDialog();
            Record record = form.Record;

            if (record != null)
            {
                // add to list and update GUI
                workshopItemsListBox.Items.Add(record);
                records.Add(record);
                numberOfItemsLabel.Text = $"There are {workshopItemsListBox.Items.Count - 1} items in this workshop";
            }
        }

        /// <summary>
        /// Updates an item in the workshop
        /// </summary>
        public void UpdateItem()
        {
            if (workshopItemsListBox.SelectedIndex > 0)
            {
                // get updated item
                ItemInformationForm form = new ItemInformationForm(records[workshopItemsListBox.SelectedIndex - 1]);
                form.ShowDialog();
                Record record = form.Record;

                // update item and GUI
                workshopItemsListBox.Items[workshopItemsListBox.SelectedIndex] = record;
                records[workshopItemsListBox.SelectedIndex - 1] = record;
            }
        }

        /// <summary>
        /// Deletes an item from the workshop
        /// </summary>
        public void DeleteItem()
        {
            if (workshopItemsListBox.SelectedIndex > 0)
            {
                // remove item and update GUI
                records.RemoveAt(workshopItemsListBox.SelectedIndex - 1);
                workshopItemsListBox.Items.RemoveAt(workshopItemsListBox.SelectedIndex);
                numberOfItemsLabel.Text = $"There are {workshopItemsListBox.Items.Count - 1} items in this workshop";
                MessageBox.Show("Item deleted. Don't forget to save.", "Success");
            } 
        }

        /// <summary>
        /// Saves all changes to the workshop file
        /// </summary>
        public void SaveWorkshop()
        {
            fileStream = new FileStream(path, FileMode.Truncate, FileAccess.Write);

            // serialize data into the file
            foreach (Record record in records)
            {
                serializer.Serialize(fileStream, record);
            }
            MessageBox.Show("Data has been saved successfully!", "Success!");
            fileStream.Close();
        }

        /// <summary>
        /// SelectedIndexChanged event form listBox, updates buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void workshopItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDeleteActiveStatus();
        }

        /// <summary>
        /// Updates menu items when closing form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WorkshopForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form = (MainMenuForm)MdiParent;
            form.ToggleDelete(false);
            form.ToggleInsert(false);
            form.ToggleSave(false);
        }

        /// <summary>
        /// Updates menu items when form is in focus again
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WorkshopForm_Enter(object sender, EventArgs e)
        {
            SetDeleteActiveStatus();
            ((MainMenuForm)MdiParent).ToggleSave(true);
        }

        /// <summary>
        /// Updates delete and update menu items
        /// </summary>
        private void SetDeleteActiveStatus()
        {
            var form = (MainMenuForm)MdiParent;

            if (workshopItemsListBox.SelectedIndex > 0)
            {
                form.ToggleDelete(true);
                form.ToggleUpdate(true);
            }
            else
            {
                form.ToggleDelete(false);
                form.ToggleUpdate(false);
            }            
        }
    }
}
