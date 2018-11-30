// Shady Boukhary

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory
{
    /// <summary>
    /// Class representing a record item
    /// </summary>
    [Serializable]
    public class Record
    {
        /* ******************************** Constructors ******************************** */

        public Record()
        {
            Name = "";
            Price = 0;
            Quantity = 0;
        }

        public Record(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        /* ******************************** Properties ******************************** */

        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        /* ******************************** Methods ******************************** */

        /// <summary>
        /// Get string representing the record in a suitable format
        /// </summary>
        /// <returns></returns>
        override public string ToString()
        {
            return $"{Name.PadRight(30 - Name.Length)}\t" +
                $"{Price.ToString().PadLeft(30 - Price.ToString().Length)}" +
                $"\t\t{Quantity.ToString().PadLeft(30 - Quantity.ToString().Length)}";
        }
    }
}
