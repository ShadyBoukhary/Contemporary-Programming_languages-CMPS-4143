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
            cart = new Cart();
            currentPizza = new Pizza();
            InitViews();
        }

        public void InitViews()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TabControlButtons_Click(object sender, EventArgs e)
        {
            if (sender == specialsButton)
            {
                tabControl.SelectedIndex = 0;
                currentPizza = new Pizza();
            }
            else
            {
                tabControl.SelectedIndex = 1;
                currentPizza = new CustomPizza();
            }
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
    }
}
