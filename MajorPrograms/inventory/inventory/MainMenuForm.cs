/* ********************************************************************************************
 * Shady Boukhary
 * November 30th, 2018
 * Contemporary Programming Languages: C#
 * Dr.Stringfellow
 * 
 * An MDI Inventory application that allows the user to store records to lists (workshops)
 * for a conference. It's a conference supplies application. All data is serialized to files
 *
 * ****************************************************************************************** */

using System;
using System.IO;
using System.Windows.Forms;

namespace inventory
{
    /// <summary>
    /// Main form, contains menustrip
    /// </summary>
    public partial class MainMenuForm : Form
    {
        /* ******************************** Constructors ******************************** */

        public MainMenuForm()
        {
            InitializeComponent();
            insertButton.Enabled = deleteButton.Enabled = saveButton.Enabled = false;
        }

        /* ******************************** Methods ******************************** */

        /// <summary>
        /// Event handler for all items in the Edit menu item
        /// Insert, delete, or update item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditMenuButtons_Click(object sender, EventArgs e)
        {
            WorkshopForm form = ((WorkshopForm)ActiveMdiChild);

            if (sender == insertButton)
                form.InsertItem();

            else if (sender == deleteButton)
                form.DeleteItem();

            else
                form.UpdateItem();
        }

        /// <summary>
        /// Event handler for all the items in the File menu item
        /// Open new or existing workshop or exit app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileMenuItem_CLick(object sender, EventArgs e)
        {
            if (sender == newButton)
                OpenNewWorkshop();

            else if (sender == openButton)
                OpenExistingWorkshop();

            else if (sender == saveButton)
                SaveWorkshop();

            else
                Application.Exit();
        }

        /// <summary>
        /// Event handler for the about menu item
        /// Show About form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().Show();
        }

        /// <summary>
        /// Opens a new workshop
        /// </summary>
        private void OpenNewWorkshop()
        {
            // to get workshop name
            WorkshopNameForm form = new WorkshopNameForm();
            form.ShowDialog();

            // validate workshop name
            if (form.WorkshopName.Length > 0)
            {
                // get path and append extension
                string path = $"{Directory.GetParent(Application.ExecutablePath)}/{form.WorkshopName}.sup";

                // open workshop mdi child form
                WorkshopForm workshopForm = new WorkshopForm(path, form.WorkshopName);
                workshopForm.MdiParent = this;
                workshopForm.Show();
            }

        }

        /// <summary>
        /// Opens an existing workshop
        /// </summary>
        private void OpenExistingWorkshop()
        {
            // Show an OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Sup Files | *.sup",
                Multiselect = false
            };

            // Open file and pass the path to the workshop mdi child form
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.FileName;
                string name = dialog.SafeFileName.Split('.')[0];
                WorkshopForm form = new WorkshopForm(path, name);
                form.MdiParent = this;
                form.Show();
            }
        }

        /// <summary>
        /// Save workshop changes
        /// </summary>
        private void SaveWorkshop()
        {
            ((WorkshopForm)ActiveMdiChild).SaveWorkshop();
        }

        /// <summary>
        /// Toggle delete button
        /// </summary>
        /// <param name="enable"></param>
        public void ToggleDelete(bool enable)
        {
            deleteButton.Enabled = enable;
        }

        /// <summary>
        /// Toggle uopdate button
        /// </summary>
        /// <param name="enable"></param>
        public void ToggleUpdate(bool enable)
        {
            updateButton.Enabled = enable;
        }

        /// <summary>
        /// Toggle insert button
        /// </summary>
        /// <param name="enable"></param>
        public void ToggleInsert(bool enable)
        {
            insertButton.Enabled = enable;
        }

        /// <summary>
        /// Toggle Save button
        /// </summary>
        /// <param name="enable"></param>
        public void ToggleSave(bool enable)
        {
            saveButton.Enabled = enable;
        }
    }
}
