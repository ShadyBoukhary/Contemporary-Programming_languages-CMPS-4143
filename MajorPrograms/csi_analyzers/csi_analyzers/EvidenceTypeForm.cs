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
    public partial class EvidenceTypeForm : Form
    {
        private SoundControl soundControl;
        public EvidenceTypeForm()
        {
            InitializeComponent();
            soundControl = SoundControl.Instance;
            InitViews();
        }

        private void InitViews()
        {
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            Utilities.SetDoubleBuffering(Controls, true);
        }

        private void buttons_Click(object sender, EventArgs e)
        {
            LoadingForm loadingForm;
            if (sender == fingerprintsButton)
            {
                loadingForm = new LoadingForm("fingerprints");
            }
            else if (sender == hairButton)
            {
                loadingForm = new LoadingForm("hair");
            }
            else
            {
                loadingForm = new LoadingForm("something");
            }
            loadingForm.Show();
            loadingForm.Shown += async (sender1, e1) => { await Task.Delay(150); Close(); };

        }

        private void buttons_MouseEnter(object sender, EventArgs e)
        {
            soundControl.PlayEffect(SoundControl.SoundType.HoverEffect);
            ((Button)sender).ForeColor = Constants.PRIMARY_COLOR;
        }

        private void buttons_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Constants.SECONDARY_COLOR;
        }

    }
}
