using Sample1.Enums;
using Sample1.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample1
{
    /// <summary>
    /// Building shopping cart
    /// </summary>
    public class Cart
    {
        public TypeOfCart TypeOfCart { get; set; }
        public List<Product> Products { get; internal set; }
        public int NumberOfItems { get {return this.Products.Count; } }

        public Cart()
        {
            Products = new List<Product>();
        }

        /// <summary>
        /// Add items to the cart
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        internal Cart AddItem(Product product)
        {
            this.Products.Add(product);
            return this;
        }

        /// <summary>
        /// Read description of products
        /// </summary>
        /// <returns></returns>
        internal string Contents()
        {
            StringBuilder description = new StringBuilder();
            foreach (var item in this.Products)
            {
                description.Append("\n");
                description.Append(item.Description);
            }
            return description.ToString();
        }

        /// <summary>
        /// Calculate price of the products
        /// </summary>
        /// <returns></returns>
        public decimal TotalPrice()
        {
            var price = this.Products.Sum(item =>item.UnitPrice * item.Quantity);
            return price;
        }
    }
}
