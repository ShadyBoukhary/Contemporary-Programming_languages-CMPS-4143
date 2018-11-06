using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza
{
    public partial class CartForm : Form
    {
        private Cart cart;

        public CartForm()
        {
            InitializeComponent();
            cart = Cart.Instance;
            InitViews();
        }

        public void InitViews()
        {
            int x = 50, y = 50;
            int offset = 50;
            Size size = Constants.ImageSize;
            foreach(Pizza pizza in cart.GetCart())
            {
                Controls.Add(GetPictureBox(pizza, x, y, size));
                Controls.Add(GetPizzaNameLabel(pizza, x, y, size, offset));
                y += size.Height + offset;
            }
        }

        private PictureBox GetPictureBox(Pizza pizza, int x, int y, Size size)
        {
            return new PictureBox
            {
                Size = new Size(size.Width, size.Height),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(x, y),
                Image = new Bitmap(pizza.GetImage()),
                BackColor = Color.Transparent
            };
        }

        private Label GetPizzaNameLabel(Pizza pizza, int x, int y, Size size, int offset)
        {
            return new Label
            {
                Size = new Size(200, 45),
                Text = pizza.Name,
                Location = new Point(x + size.Width + offset, y),
                Font = new Font(Font.FontFamily, 16, FontStyle.Bold)
            };
        }
    }
}
