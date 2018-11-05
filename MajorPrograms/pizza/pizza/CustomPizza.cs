using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza
{
    public class CustomPizza : Pizza
    {
        /* ************************************ Properties ************************************ */
        public CustomPizza() : base() {}

        public Sauce PizzaSauce { set; get; }
        public Cheese PizzaCheese { set; get; }
        public Meat PizzaMeat { set; get; }
        public Veggies PizzaVeggies { set; get; }
        override public decimal TotalPrice => GetSizePrice() + GetSaucePrice() + GetCheesePrice() + GetMeatPrice() + GetVeggiesPrice();
        override public string Name => "Custom Pizza";

        /* ************************************ Methods ************************************ */

        public decimal GetSaucePrice()
        {
            switch (PizzaSauce)
            {
                case Sauce.Alfredo:
                    return 1.99M;
                default:
                    return 0.99M;
            }
        }

        public decimal GetCheesePrice()
        {
            switch (PizzaCheese)
            {
                case Cheese.Mozzerella:
                    return 0.99M;
                case Cheese.Parmesan:
                    return 0.59M;
                default:
                    return 1.59M;
            }
        }

        public decimal GetMeatPrice()
        {
            switch (PizzaMeat)
            {
                case Meat.Chicken:
                    return 2.99M;
                case Meat.Beef:
                    return 1.99M;
                case Meat.Sausage:
                    return 1.59M;
                default:
                    return 0.99M;
            }
        }

        public decimal GetVeggiesPrice()
        {
            switch (PizzaVeggies)
            {
                case Veggies.Broccoli:
                    return 1.99M;
                case Veggies.Mushrooms:
                    return 2.59M;
                default:
                    return 1.59M;
            }
        }
        /* ************************************ Enums ************************************ */

        public enum Sauce
        {
            Alfredo,
            Tomato
        }

        public enum Cheese
        {
            Mozzerella,
            Provolone,
            Parmesan
        }

        public enum Meat
        {
            Chicken,
            Sausage,
            Beef,
            Pepperoni
        }

        public enum Veggies
        {
            Mushrooms,
            Broccoli,
            Spinach
        }
    }
}
