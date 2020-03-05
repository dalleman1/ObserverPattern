using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExercise
{
    public class Portfolio_observer : IObserver
    {
        List<Stock> e = new List<Stock>();
        struct Stock
        {
            public string Stockname { get; set; }

            public int AmountofStocks { get; set; }

            public int Value { get; set; }
        };

        public void Update(Stock s)
        {
            Stock _Stock = new Stock();

            for (int i = 0; i < e.Count; i++)
            {
                if (_Stock.Stockname == s.Stockname)
                {
                    _Stock.Value = s.Value;
                }
            }
        }
    }
}
