using Sample1.Enums;
using Sample1.Interfaces;

namespace Sample1.Factory
{
    public abstract class Product : IObjectInterface
    {
        public TypeOfProduct Type { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Weight { get; set; }
        public Product WithDescription(string description)
        {
            Description = description;
            return this;
        }
        public Product WithUnitPrice(decimal unitPrice)
        {
            UnitPrice = unitPrice;
            return this;
        }

        public Product WithWeight(decimal weight)
        {
            Weight = weight;
            return this;
        }

        public Product WithQuantity(int quantity)
        {
            Quantity = quantity;
            return this;
        }

        
    }
}
