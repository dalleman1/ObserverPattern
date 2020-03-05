using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExercise
{
    public class Stock_concretesubject : Stock_subject
    {
        public void Notify()
        {
            foreach (var stock in base.observers)
            {
                stock temp = new stock { Stockname };
                stock.Update()
            }
        }

    }
}
