using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExercise
{
    public class Stock_concretesubject : Stock_subject
    {

        private string stockName;
        private int amountofstocks;
        private int value_;

        public string _Stockname { 
            
            get => stockName;

            set 
            {
                stockName = value;
                Notify(); 

            }
        }

        public int _AmountOfStocks
        {

            get => amountofstocks;

            set
            {
                amountofstocks = value;
                Notify();

            }
        }

        public int _Value
        {

            get => value_;

            set
            {
                value_ = value;
                Notify();

            }
        }

        public Stock_concretesubject(string _stockname, int _amountofstocks, int _value)
        {
            _Stockname = _stockname;
            _AmountOfStocks = _amountofstocks;
            _Value = _value;
            Notify();
        }

        public Stock_concretesubject()
        { }


        public override void Notify()
        {
            foreach (var stock in base.observers)
            {
                Portfolio_observer.Stock temp = new Portfolio_observer.Stock(_Stockname, _AmountOfStocks, _Value);
                stock.Update(temp);
            }
        }
    }
}
