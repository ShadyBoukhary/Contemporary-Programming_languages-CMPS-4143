using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza
{
    public class Pizza
    {
        public Pizza()
        {
            PizzaSize = Size.Medium;
        }

        public Size PizzaSize { set; get; }

        virtual public string Name { set; get; }
        virtual public decimal TotalPrice => GetSizePrice() + GetSpecialtyPrice();
        public Specialty SpecialtyType { get; set; }

        public decimal GetSizePrice()
        {
            switch (PizzaSize)
            {
                case Size.Personal:
                    return 1.99M;
                case Size.Small:
                    return 2.99M;
                case Size.Medium:
                    return 3.99M;
                default:
                    return 4.59M;
            }
        }

        private decimal GetSpecialtyPrice()
        {
            switch (SpecialtyType)
            {
                case Specialty.MeatLovers:
                    return 5.99M;
                case Specialty.CheeseLovers:
                    return 3.99M;
                case Specialty.VeggieLovers:
                    return 4.99M;
                default:
                    return 6.99M;
            }
        }

        public enum Size
        {
            Personal,
            Small,
            Medium,
            Large
        }

        public enum Specialty
        {
            MeatLovers,
            CheeseLovers,
            VeggieLovers,
            Italiano
        }
    }
}
