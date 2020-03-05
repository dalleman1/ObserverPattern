using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExercise
{
    public class Portfolio_observer : IObserver
    {
        public int TotalValue;
        public Portfolio_display _display = new Portfolio_display();

        public List<Stock> stockList = new List<Stock>();
        public class Stock
        {
            public string Stockname { get; set; }

            public int AmountofStocks { get; set; }

            public int Value { get; set; }

            public Stock(string _Stockname, int _AmountofStocks, int _Value)
            {
                Stockname = _Stockname;
                AmountofStocks = _AmountofStocks;
                Value = _Value;
            }
        };



        public void Update(Stock s)
        {
            int tempTotal = 0;

            if (stockList.Count <= 0)
            {
                stockList.Add(s);
                TotalValue = s.Value;
                _display.Display(stockList, TotalValue);

            }
            else
            {
                if (stockList.Any( item => item.Stockname == s.Stockname))
                {
                    foreach (var obj in stockList.ToList())
                    {
                        if (obj.Stockname == s.Stockname)
                        {
                            obj.Value = s.Value;
                            obj.AmountofStocks = s.AmountofStocks;
                        }

                    }
                } else
                {
                    stockList.Add(s);
                }


                foreach(var obj in stockList.ToList())
                {

                    tempTotal += obj.Value;
                }


                TotalValue = tempTotal;
                _display.Display(stockList, TotalValue);
            }
            
            
        }
    }
}
