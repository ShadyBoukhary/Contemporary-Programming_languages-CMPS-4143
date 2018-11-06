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
            Size size = Constants.ImageSize;
            foreach(Pizza pizza in cart.GetCart())
            {
                PictureBox pictureBox = new PictureBox
                {
                    Size = new Size(size.Width, size.Height),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Location = new Point(x, y),
                    Image = pizza.GetImage(),
                    BackColor = Color.Transparent
                };

                y += y + size.Height;
                Controls.Add(pictureBox);
            }
        }
    }
}
