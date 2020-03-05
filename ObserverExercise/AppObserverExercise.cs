using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://i.imgur.com/ykS9SDS.png

namespace ObserverExercise
{
    class AppObserverExercise
    {
        static void Main(string[] args)
        {
            Portfolio_observer po = new Portfolio_observer();
            Stock_concretesubject stock1 = new Stock_concretesubject();
            Stock_concretesubject stock2 = new Stock_concretesubject();
            Stock_concretesubject stock3 = new Stock_concretesubject();

            //po.stockList.Add(new Portfolio_observer.Stock("Viktor",3,5000));
            //po.stockList.Add(new Portfolio_observer.Stock("Morten", 1, 200));
            //po.stockList.Add(new Portfolio_observer.Stock("Rasmus", 100, 1000));

            stock1.Attach(po);
            stock2.Attach(po);
            stock3.Attach(po);

            stock1._Stockname = "Viktor";
            stock1._Value = 100;
            stock1._AmountOfStocks = 3;

            stock2._Stockname = "Ralle";
            stock2._Value = 100;
            stock2._AmountOfStocks = 3;

            stock3._Stockname = "Morten";
            stock3._Value = 100;
            stock3._AmountOfStocks = 3;


            Console.ReadKey();

            stock1._Value = 1000;


            Console.ReadKey();

            stock2._Value = 100;

            Console.ReadKey();

            stock3._Value = 1;
            stock1._Value = 9999999;
            Stock_concretesubject stock4 = new Stock_concretesubject("Rallezxxx", 100, 100000);
            stock4.Attach(po);
            stock4._Value = 100;


            Console.ReadKey();





        }
    }
}
