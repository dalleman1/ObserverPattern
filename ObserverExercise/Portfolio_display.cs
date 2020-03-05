using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExercise
{
    public class Portfolio_display : IDisplay
    {
        public void Display(List<Portfolio_observer.Stock> stocks, int _totalValue)
        {
            Console.Clear();
            foreach (var obj in stocks)
            {
                Console.WriteLine($"stock name: {obj.Stockname}, Amount of stocks: {obj.AmountofStocks}, Value: {obj.Value} ");
                Console.WriteLine("");
            }
            Console.WriteLine($"Total value: {_totalValue}");
            Console.WriteLine();
        }

    }
}
