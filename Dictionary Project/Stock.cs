using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary_Project
{
    public class Stock
    {
        public int HighestStockPrice { get; set; }
        public int LowestStockPrice { get; set; }
        public int LatestStockPrice { get; set; }
        public int TotalStockPrice { get; set; }
        public int Count { get; set; }
    }
    public class StockOperation
    {
        Dictionary<string, Stock> _stock = new();
        public void AddStock(string stockName, int price)
        {

            if (price <= 0)
                throw new ArgumentException("Stock price must more than 0");



            if (!_stock.ContainsKey(stockName))
            {
                _stock[stockName] = new Stock()
                {
                    HighestStockPrice = price,
                    LowestStockPrice = price,
                    LatestStockPrice = price,
                    TotalStockPrice = price,
                    Count = 0
                };
                return;
            }

            var stock = _stock[stockName];
            stock.HighestStockPrice = Math.Max(stock.HighestStockPrice, price);
            stock.LowestStockPrice = Math.Min(stock.LowestStockPrice, price);
            stock.LatestStockPrice = price;
            stock.TotalStockPrice += price;
            stock.Count++;
        }

        public int GetHighestStockPrice(string stockName)
        {
            if (!_stock.TryGetValue(stockName, out Stock? stock))
                throw new KeyNotFoundException("Invalid Stock Name");

            return stock.HighestStockPrice;
        }

        public int GetLowestStockPrice(string stockName)
        {
            if (!_stock.TryGetValue(stockName, out Stock? stock))
                throw new KeyNotFoundException("Invalid Stock Name");

            return stock.LowestStockPrice;
        }

        public double GetAverageStockPrice(string stockName)
        {
            if (!_stock.TryGetValue(stockName, out Stock? stock))
                throw new KeyNotFoundException("Invalid Stock Name");

            return (double)stock.TotalStockPrice / stock.Count;
        }

        public int GetLatestStockPrice(string stockName)
        {
            if (!_stock.TryGetValue(stockName, out Stock? stock))
                throw new KeyNotFoundException("Invalid Stock Name");

            return stock.LatestStockPrice;
        }
    }
}
