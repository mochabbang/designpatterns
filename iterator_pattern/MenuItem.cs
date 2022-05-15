namespace designpatterns.iterator_pattern
{
    public class MenuItem
    {
        private string name;
        private string description;
        private bool vegetarian;
        private double price;

        public MenuItem(string name, string description, bool vegetarian, double price) {
            this.name = name;
            this.description = description;
            this.vegetarian = vegetarian;
            this.price = price;
        } 

        public string GetName() {
            return name;
        }

        public string GetDescription() {
            return description;
        }

        public double GetPrice() {
            return price;
        }

        public bool IsVegetarian() {
            return vegetarian;
        }
    }
}