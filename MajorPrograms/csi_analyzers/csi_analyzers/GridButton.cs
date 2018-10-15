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
    public partial class GridButton : Button
    {
        const int startX = 88;
        const int startY = 200;
        public GridButton(int row, int column) : base()
        {
            InitializeComponent();
            Size = new Size(48, 48);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 1;
            FlatAppearance.BorderColor = Color.Black;
            Top = startX + row * Height;
            Left = startY + column * Width;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
