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
        private Settings settings;
        private bool isImported;
        private string path;
        private string type;

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
            GridButton[,] gridButtons;
            int maxRows, maxCols;
            if (settings.CanImport)
            {

            }
            else
            {
                maxRows = Utilities.GetRandomInt(3, 12);
                maxCols = Utilities.GetRandomInt(3, 12);

                gridButtons = new GridButton[maxRows, maxCols];

                for (int row = 0; row < maxRows; row++)
                {
                    int rowProgress = (row + 1) * 99 / maxRows;

                    for (int col = 0; col < maxCols; col++)
                    {
                        int colProgress = (col + 1) * maxCols / (maxRows * maxCols);
                        gridButtons[row, col] = new GridButton(row, col);
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

        private void loadingBackgroundWorker_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            Console.WriteLine("Done");
        }

        private void LoadingForm_Shown(object sender, EventArgs e)
        {
            loadingBackgroundWorker.RunWorkerAsync();
        }
    }
}
