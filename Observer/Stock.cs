namespace Observer
{
    class Stock : Subject
    {
        private readonly string _symbol;
        private float _price;

        public string Symbol { get => _symbol; }

        public float Price 
        { 
            get => _price; 

            set
            {
                _price = value;
                NotifyObservers();
            } 
        }

        public Stock(string symbol, float price)
        {
            _symbol = symbol;
            _price = price;
        }

        public override string ToString()
        {
            return "Stock{" +
                "symbol='" + _symbol + '\'' +
                ", price=" + _price +
                '}';
        }
    }
}