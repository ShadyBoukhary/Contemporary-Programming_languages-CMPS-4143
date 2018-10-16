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
        const int START_X = 0;
        const int START_Y = 0;
        const int BUTTON_SIZE_X = 30;
        public GridButton(int row, int column, int sizeX, int sizeY) : base()
        {
            InitializeComponent();
            Size = new Size(sizeY, sizeX);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 1;
            FlatAppearance.BorderColor = Color.CornflowerBlue;
            FlatAppearance.CheckedBackColor = Color.Transparent;
            FlatAppearance.MouseDownBackColor = Color.FromArgb(50, Color.CornflowerBlue);
            FlatAppearance.MouseOverBackColor = Color.FromArgb(90, Color.CornflowerBlue);
            Top = START_X + row * Height;
            Left = START_Y + column * Width;

            Tag = $"{row},{column}";
        }



        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }


    }
}
