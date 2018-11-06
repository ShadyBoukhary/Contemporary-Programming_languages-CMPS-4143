using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace pizza
{
    static class Constants
    {
        public static Image DefaultImage => Properties.Resources.crust_handtossed;
        public static Image MeatLoversImage => Properties.Resources.pepperoni_pizza;
        public static Image CheeseLoversImage => Properties.Resources.cheese_pizza;
        public static Image VeggieLoversImage => Properties.Resources.veggie;
        public static Image ItalianoImage => Properties.Resources.italian;

        public static string SuccessMessage => "Success!";
        public static string AddedToCartMessage => "Your pizza has been added to the cart!";
        public static string CartClearedMessage => "The cart has been cleared!";

        public static Size ImageSize => new Size(225, 208);
    }
}
