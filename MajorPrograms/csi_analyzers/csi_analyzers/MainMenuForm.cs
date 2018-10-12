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
        private SoundControl soundControl;
        private Func<Task> formClosedEventHandler;

        public MainMenuForm()
        {
            InitializeComponent();
            soundControl = SoundControl.Instance;
            // Back Button lambda
            formClosedEventHandler = async () => { Show();  await Task.Delay(100); };
            Utilities.SetDoubleBuffering(Controls, true);
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            initViews();
            
            
        }

        private void initViews()
        {
            playButton.BackColor = Color.FromArgb(0, Color.DarkBlue);
            playButton.ForeColor = Color.FromArgb(100, Constants.PRIMARY_COLOR);
            instructionsButton.BackColor = Color.FromArgb(0, Color.DarkBlue);
            instructionsButton.ForeColor = Color.FromArgb(100, Constants.PRIMARY_COLOR);
            settingsButton.BackColor = Color.FromArgb(0, Color.DarkBlue);
            settingsButton.ForeColor = Color.FromArgb(100, Constants.PRIMARY_COLOR);

            exitButton.BackColor = Color.FromArgb(0, Color.DarkBlue);
            exitButton.ForeColor = Color.FromArgb(100, Constants.PRIMARY_COLOR);

            mainMenuGroupBox.BackColor = Color.FromArgb(30, Constants.PRIMARY_COLOR);
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            soundControl.PlayMenuTheme();
        }


        private void buttons_OnMouseEnter(object sender, EventArgs e)
        {
            soundControl.PlayEffect(SoundControl.SoundType.HoverEffect);
            ((Button)sender).ForeColor = Constants.SECONDARY_COLOR;

        }

        private void buttons_OnMouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Constants.PRIMARY_COLOR;
        }

        async private void buttons_Click(object sender, MouseEventArgs e)
        {
            if (sender == playButton)
            {
                soundControl.PlayEffect(SoundControl.SoundType.DefaultEffect);

            }
            else if (sender == instructionsButton)
            {
                soundControl.PlayEffect(SoundControl.SoundType.DefaultEffect);
                InstructionsForm instructionsForm = new InstructionsForm(formClosedEventHandler);
                instructionsForm.Show();
                await Task.Delay(100);
                Hide();
            }
            else if (sender == settingsButton)
            {
                soundControl.PlayEffect(SoundControl.SoundType.DefaultEffect);
            }
            else   // exit button
            {
                soundControl.PlayEffect(SoundControl.SoundType.CancelEffect);
                await Task.Delay(100);
                Close();
            }
        }


    }
}
