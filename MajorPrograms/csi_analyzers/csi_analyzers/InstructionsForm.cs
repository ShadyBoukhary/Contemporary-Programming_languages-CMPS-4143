using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csi_analyzers
{
    public partial class InstructionsForm : Form
    {
        private SoundControl soundControl;
        private Func<Task> onCloseLambda;

        public InstructionsForm(Func<Task> onCloseLambda)
        {
            InitializeComponent();
            InitViews();

            this.soundControl = SoundControl.Instance;
            this.onCloseLambda = onCloseLambda;
        }

        private void InitViews()
        {
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            Utilities.SetDoubleBuffering(Controls, true);
            instructionsGroupBox.BackColor = Color.FromArgb(30, Color.CornflowerBlue);
        }

        async private void okButton_Click(object sender, EventArgs e)
        {
            // show main form before closing this form to prevent flickers
            soundControl.PlayDefaultButton();
            await onCloseLambda();
            Close();
        }

        private void InstructionsForm_Load(object sender, EventArgs e)
        {
            string s = "Hello detective, how are you?";
        }
    }
}
