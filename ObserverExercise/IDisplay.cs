using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExercise
{
    public interface IDisplay
    {
        void Display(List<Portfolio_observer.Stock> stocks, int _totalValue);
    }
}
