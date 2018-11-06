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
    public partial class PizzaPickerForm : Form
    {
        bool isCustom;
        Cart cart;
        Pizza currentPizza;

        public PizzaPickerForm()
        {
            InitializeComponent();
            isCustom = false;
            cart = Cart.Instance;
            currentPizza = new Pizza();
            InitViews();
        }

        public void InitViews()
        {
            orderPictureBox.Image = currentPizza.DefaultImage;
            personalSizeRadioButton.Checked = smallSizeRadioButton.Checked = largeSizeRadioButton.Checked = false;
            mediumSizeRadioButton.Checked = true;
            addToCartButton.Enabled = false;

            if (isCustom)
            {
                alfredoRadioButton.Checked = tomatoRadioButton.Checked = mozzerrellaRadioButton.Checked =
                    provoloneRadioButton.Checked = parmesanRadioButton.Checked = chickenRadioButton.Checked =
                    sausageRadioButton.Checked = beefRadioButton.Checked = pepperoniRadioButton.Checked =
                    mushroomsRadioButton.Checked = broccoliRadioButton.Checked = spinachRadioButton.Checked = false;
            }

            checkoutButton.Enabled = cart.IsEmpty;
        }

        private void ClearOrder()
        {
            currentPizza = isCustom ? new CustomPizza() : new Pizza();
            InitViews();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TabControlButtons_Click(object sender, EventArgs e)
        {
            if (sender == specialsButton)
            {
                tabControl.SelectedIndex = 0;
                isCustom = false;
                currentPizza = new Pizza();
            }
            else
            {
                tabControl.SelectedIndex = 1;
                isCustom = true;
                currentPizza = new CustomPizza();
            }
            ClearOrder();
        }

        private void SpecialtyPizzaButtons_Click(object sender, EventArgs e)
        {
            if (sender == meatButton)
                currentPizza.SpecialtyType = Pizza.Specialty.MeatLovers;

            else if (sender == cheeseButton)
                currentPizza.SpecialtyType = Pizza.Specialty.CheeseLovers;

            else if (sender == veggieButton)
                currentPizza.SpecialtyType = Pizza.Specialty.VeggieLovers;

            else
                currentPizza.SpecialtyType = Pizza.Specialty.Italiano;

            orderPictureBox.Image = currentPizza.GetImage();
            addToCartButton.Enabled = true;
        }

        private void SizeRadioButtons_Click(object sender, EventArgs e)
        {
            if (sender == personalSizeRadioButton)
                currentPizza.PizzaSize = Pizza.Size.Personal;

            else if (sender == smallSizeRadioButton)
                currentPizza.PizzaSize = Pizza.Size.Small;

            else if (sender == mediumSizeRadioButton)
                currentPizza.PizzaSize = Pizza.Size.Medium;

            else
                currentPizza.PizzaSize = Pizza.Size.Large;
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            cart.AddToCart(currentPizza);
            MessageBox.Show(Constants.AddedToCartMessage, Constants.SuccessMessage, 
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            ClearOrder();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            ClearOrder();
        }

        private void SauceRadioButtons_Click(object sender, EventArgs e)
        {
            CustomPizza pizza = (CustomPizza)currentPizza;
            pizza.PizzaSauce = sender == alfredoRadioButton ? CustomPizza.Sauce.Alfredo : CustomPizza.Sauce.Tomato;
        }

        private void CheeseRadioButtons_Click(object sender, EventArgs e)
        {
            CustomPizza pizza = (CustomPizza)currentPizza;

            if (sender == mozzerrellaRadioButton)
                pizza.PizzaCheese = CustomPizza.Cheese.Mozzerella;

            else if (sender == provoloneRadioButton)
                pizza.PizzaCheese = CustomPizza.Cheese.Provolone;

            else
                pizza.PizzaCheese = CustomPizza.Cheese.Parmesan;
        }

        private void MeatRadioButtons_Click(object sender, EventArgs e)
        {
            CustomPizza pizza = (CustomPizza)currentPizza;

            if (sender == chickenRadioButton)
                pizza.PizzaMeat = CustomPizza.Meat.Chicken;

            else if (sender == sausageRadioButton)
                pizza.PizzaMeat = CustomPizza.Meat.Sausage;

            else if (sender == beefRadioButton)
                pizza.PizzaMeat = CustomPizza.Meat.Beef;

            else
                pizza.PizzaMeat = CustomPizza.Meat.Pepperoni;
        }

        private void VeggiesRadioButtons_Click(object sender, EventArgs e)
        {
            CustomPizza pizza = (CustomPizza)currentPizza;

            if (sender == mushroomsRadioButton)
                pizza.PizzaVeggies = CustomPizza.Veggies.Mushrooms;

            else if (sender == broccoliRadioButton)
                pizza.PizzaVeggies = CustomPizza.Veggies.Broccoli;

            else
                pizza.PizzaVeggies = CustomPizza.Veggies.Spinach;
        }

        private void CustomRadioButtons_CheckChanged(object sender, EventArgs e)
        {
            if ((alfredoRadioButton.Checked || tomatoRadioButton.Checked)
                && (mozzerrellaRadioButton.Checked || provoloneRadioButton.Checked || parmesanRadioButton.Checked)
                && (chickenRadioButton.Checked || sausageRadioButton.Checked || beefRadioButton.Checked ||
                pepperoniRadioButton.Checked)
                && (mushroomsRadioButton.Checked || broccoliRadioButton.Checked || spinachRadioButton.Checked))
            {
                addToCartButton.Enabled = true;
            }
        }

        private void clearCartButton_Click(object sender, EventArgs e)
        {
            cart.ClearCart();
            MessageBox.Show(Constants.CartClearedMessage, 
                            Constants.SuccessMessage, 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
            ClearOrder();
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            CartForm form = new CartForm();
            form.Show();
            Hide();
        }
    }
}
