using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace csi_analyzers
{
    public partial class MainMenuForm : Form
    {
        private SoundPlayer Player = new SoundPlayer();

        public MainMenuForm()
        {
            InitializeComponent();
            Utilities.SetDoubleBuffering(Controls, true);
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            
            
             mainMenuGroupBox.BackColor = Color.FromArgb(80, Color.Black);

        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            SoundControl.Instance.PlayMenuTheme();
        }

        
    }
}
