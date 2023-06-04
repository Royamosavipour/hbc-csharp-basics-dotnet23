namespace Exercise004
{
    public class Product
    {
        // DO NOT TOUCH THESE VARIABLES
        private string name;
        private string location;
        private int weight;

        // CREATE YOUR CONSTRUCTORS HERE
        public Product(string name)
        {
            this.name = name;
            location = "shelf";
            weight = 1;
        }
        public Product(string name, string location)
        {
            this.name = name;
            this.location = location;
            weight = 1;

        }
        public Product(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
            location = "warehouse";

        }



        // DO NOT TOUCH THIS
        public override string ToString()
        {
            return $"{this.name} ({this.weight} kg) can be found from the {this.location}.";
        }
    }
}