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
    public partial class LoadingForm : Form
    {
        const int PANEL_MAX_WIDTH = 900;
        const int PANEL_MAX_HEIGHT = 905;
        private Settings settings;
        private bool isImported;
        private string path;
        private string type;
        private GridButton[,] gridButtons;

        public LoadingForm(string type)
        {
            InitializeComponent();
            InitViews();
            settings = Settings.Instance;
            this.type = type;
        }

        private void InitViews()
        {
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            Utilities.SetDoubleBuffering(Controls, true);
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            loadingBackgroundWorker.RunWorkerAsync();

        }

        private void loadingBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            
            int maxRows, maxCols;
            if (settings.CanImport)
            {

            }
            else
            {
                maxRows = Utilities.GetRandomInt(5, 30);
                maxCols = Utilities.GetRandomInt(9, 30);

                gridButtons = new GridButton[maxRows, maxCols];

                for (int row = 0; row < maxRows; row++)
                {
                    int rowProgress = (row + 1) * 99 / maxRows;

                    for (int col = 0; col < maxCols; col++)
                    {
                        int colProgress = (col + 1) * maxCols / (maxRows * maxCols);
                        gridButtons[row, col] = new GridButton(row, col, PANEL_MAX_HEIGHT / maxRows, PANEL_MAX_WIDTH / maxCols);
                        int progress = rowProgress + colProgress;
                        loadingBackgroundWorker.ReportProgress(progress <= 100 ? progress : 100);
                    }
                }
            }
        }

        private void loadingBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        async private void loadingBackgroundWorker_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            GameForm gameForm = new GameForm(gridButtons, type);
            await Task.Delay(1000);
            SoundControl.Instance.StopTheme();
            progressBar.Hide();
            loadingLabel.Hide();
            gameForm.Show();
            
            gameForm.Shown += async (sender1, e1) => { await Task.Delay(2000); Close(); };
        }

        private void LoadingForm_Shown(object sender, EventArgs e)
        {
            loadingBackgroundWorker.RunWorkerAsync();
        }
    }
}
