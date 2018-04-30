namespace PA_4_Console
{
    public class Product
    {
        private string _name; //The name of the product
        private int _ID; //Product's ID number
        private double _price; //Prduct's Price represented as a double ($XX.xx)

        /// <summary>
        /// Constructs a new Product object.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ID"></param>
        /// <param name="price"></param>
        public Product(string name, int ID, double price)
        {
            _name = name;
            _ID = ID;
            _price = price;
        }

        /// <summary>
        /// Getter for the _name field
        /// </summary>
        public string GetName
        {
            get
            {
                return _name;
            }
        }

        /// <summary>
        /// Getter for the _price field
        /// </summary>
        public double GetPrice
        {
            get
            {
                return _price;
            }
        }

        /// <summary>
        /// Getter for _ID field
        /// </summary>
        public int ID
        {
            get
            {
                return _ID;
            }
        }
    } // end class
}// namespace



