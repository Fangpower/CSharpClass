/*
 * @author Mikey Dowsett
 * Class Item represents an item with a name, price, and quantity.
 */
namespace SodaInheritance {
    internal class Item {
        public string Name { get; set; }

        private decimal price;
        public decimal Price {
            get => price;
            set {
                if (value >= 0) price = value;
            }
        }

        private int quantity;
        public int Quantity {
            get => quantity;
            set {
                if (value >= 0) quantity = value;
            }
        }

        public Item() { 
            Name = "-"; 
            Price = 0;
            Quantity = 0; 
        }

        public Item(string name, decimal price, int quantity) {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString() => $"{Name}, {Price:C}, {Quantity}";

        /**
         * Recduce reduces the quantity in stock
         * @param amount The amount by which to reuce the quantity*/
        public void Reduce(int amount) {
            if(amount > 0 && Quantity >= amount)
                Quantity -= amount;
        }
    }
}
