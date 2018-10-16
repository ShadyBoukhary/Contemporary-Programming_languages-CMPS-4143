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
    public partial class GameForm : Form
    {
        private GridButton[,] gridButtons;
        private SoundControl soundControl;
        private readonly int totalAllowedTime;
        private int timeRemaining;
        public GameForm(GridButton[,] gridButtons, string type)
        {
            InitializeComponent();
            soundControl = SoundControl.Instance;
            this.gridButtons = gridButtons;
            timeRemaining = totalAllowedTime = 202;
            InitViews();
        }

        private void InitViews()
        {
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            foreach (GridButton button in gridButtons)
            {
                panel.Controls.Add(button);
            }
            Utilities.SetDoubleBuffering(Controls, true);

            
        }

        async private void GameForm_Load(object sender, EventArgs e)
        {
            soundControl.PlayTheme(SoundControl.SoundType.InGameTheme);
            Console.WriteLine(panel.Size);
            await Task.Delay(1000);
            timerBackgroundWorker.RunWorkerAsync();
        }

        private void timerBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < totalAllowedTime; i++)
            {
                // Sleep background thread (blocking sleep). Did not use await Task.Delay()
                // because async await cannot be used with a background worker => exit point for thread
                // it's okay to use blocking sleep with a thread as long as it's not a GUI thread
                System.Threading.Thread.Sleep(1000);    
                timeRemaining--;
                timerBackgroundWorker.ReportProgress(i * 100 / totalAllowedTime);
            }
            
            
        }

        private void timerBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int minutes = timeRemaining / 60;
            int seconds = timeRemaining % 60;
            string secondsStr = seconds < 10 ? $"0{seconds}" : seconds.ToString();

            timeLeftLabel.Text = $"{minutes}:{secondsStr}";
            timerProgressBar.Value = 100 - e.ProgressPercentage;

            if (minutes < 1)
            {
                timeLeftLabel.ForeColor = Color.Red;
                hurryLabel.Show();

                if (seconds < 20)
                    hurryLabel.ForeColor =  timeLeftLabel.ForeColor = seconds % 2 == 0 ? Color.Red : Color.White;
                   

            }

        }

        private void timerBackgroundWorker_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            timerProgressBar.Value = 0;
        }
    }
}
