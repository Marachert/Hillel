namespace HomeWork2
{
    public abstract class Appliances
    {
        private int _price = 0;
        public int Price { 
            get
            {
                return _price;
            } 
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Price not valid");
                    return;
                }
                _price = value;
            }
        }
        public string? Name { get; set; }
        public Appliances(int price, string? name)
        {
            this.Price = price;
            this.Name = name;
        }

        public Appliances()
        {

        }

        public abstract void Action();
    }
}
