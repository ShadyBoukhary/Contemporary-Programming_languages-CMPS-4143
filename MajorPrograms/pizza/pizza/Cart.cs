using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza
{
    public class Cart
    {
        private List<Pizza> cart;
        private static Cart instance;
        public static Cart Instance => instance ?? (instance = new Cart());

        private Cart()
        {
            cart = new List<Pizza>();
        }

        public decimal SubTotal
        {
            get
            {
                decimal totalPrice = 0;
                foreach (Pizza pizza in cart)
                    totalPrice += pizza.TotalPrice;

                return totalPrice;
            }
        }

        public decimal Total => SubTotal + SubTotal * 0.10M;
        public bool IsEmpty => cart.Count > 0;
        
        public void AddToCart(Pizza pizza)
        {
            cart.Add(pizza);
        }

        public List<Pizza> GetCart()
        {
            return cart;
        }

        public void ClearCart()
        {
            cart.Clear();
        }

    }
}
