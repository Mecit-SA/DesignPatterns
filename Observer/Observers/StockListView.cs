namespace Observer
{
    class StockListView : IObserver
    {
        private readonly ICollection<Stock> _stocks = new List<Stock>();

        public void AddStock(Stock stock)
        {
            _stocks.Add(stock);
            stock.AddObserver(this);
        }

        public void Update()
        {
            Console.WriteLine("\nList View Updated :");
            Show();
        }

        void Show()
        {
            foreach (Stock stock in _stocks)
                Console.WriteLine(stock);
        }
    }
}