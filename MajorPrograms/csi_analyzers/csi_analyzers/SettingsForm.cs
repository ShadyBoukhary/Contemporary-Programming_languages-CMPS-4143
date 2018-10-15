using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csi_analyzers
{
    public partial class SettingsForm : Form
    {
        private readonly SoundControl soundControl;
        private readonly Settings settings;
        private Func<Task> onCloseLambda;

        private bool canImport;
        private string difficulty;
        private string path;

        public SettingsForm(Func<Task> onCloseLambda)
        {
            InitializeComponent();
            soundControl = SoundControl.Instance;
            settings = Settings.Instance;
            this.onCloseLambda = onCloseLambda;
            InitViews();
            RetrieveSettings();
        }

        private void InitViews()
        {
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            Utilities.SetDoubleBuffering(Controls, true);
            settingsGroupBox.BackColor = Color.FromArgb(30, Constants.PRIMARY_COLOR);
            descriptionLabel.BackColor = Color.Transparent;
            importCheckBox.BackColor = Color.Transparent;
            uploadButton.Enabled = false;
        }

        private void RetrieveSettings()
        {
            canImport = settings.CanImport;
            difficulty = settings.Difficulty;
            path = settings.ImportedScenesPath;

            uploadButton.Enabled = importCheckBox.Checked = canImport;

            switch (difficulty)
            {
                case "easy":
                    easyRadioButton.Checked = true;
                    break;

                case "medium":
                    mediumRadioButton.Checked = true;
                    break;

                default:
                    hardRadioButton.Checked = true;
                    break;
            }
        }

        private void button_OnMouseEnter(object sender, EventArgs e)
        {
            soundControl.PlayEffect(SoundControl.SoundType.HoverEffect);
            ((Button)sender).ForeColor = Constants.PRIMARY_COLOR;
        }

        private void button_OnMouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Constants.SECONDARY_COLOR;
        }

        private void importCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            canImport = !canImport;
            uploadButton.Enabled = !uploadButton.Enabled;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == easyRadioButton)
                difficulty = "easy";

            else if (sender == mediumRadioButton)
                difficulty = "medium";

            else
                difficulty = "hard";
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = Utilities.GetTextFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
                pathLabel.Text += path = dialog.FileName;
            

            //using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding())) // do anything you want, e.g. read it
            //{
            //    // ...
            //}

        }

        async private void backButtons_Click(object sender, EventArgs e)
        {
            // show main form before closing this form to prevent flickers
            if (sender == okButton)
            {
                soundControl.PlayEffect(SoundControl.SoundType.DefaultEffect);
                settings.SaveSettings(difficulty, canImport, path);
            }
            else
            {
                soundControl.PlayEffect(SoundControl.SoundType.CancelEffect);
            }

            await onCloseLambda();
            Close();
        }

        
    }
}
