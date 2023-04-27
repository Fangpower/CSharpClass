/**
 * @author Mikey Dowsett
 * Class Soda represents a soda with Item and ounces.
 */
namespace SodaInheritance {
    internal class Soda : Item {
        private int ounces;
        public int Ounces {
            get => ounces;
            set {
                if (value >= 0) {
                    ounces = value;
                }
            }
        }

        public Soda() : base() {
            Ounces = 0;
        }

        public Soda(string name, decimal price, int quantity, int ounces) 
            : base(name, price, quantity) {
            Ounces = ounces;
        }

        public override string ToString() => $"{base.ToString()}, {Ounces}";
    }
}
