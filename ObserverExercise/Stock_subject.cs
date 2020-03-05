using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExercise
{
    public abstract class Stock_subject
    {
        protected List<IObserver> observers = new List<IObserver>();
        
        void Attach(IObserver obs)
        {
            observers.Add(obs);
        }

        void Dettach(IObserver obs)
        {
            int i = observers.indexOf(obs);
            if (i >= 0)
            {
                observers.remove(i);
            }
        }

        public abstract void Notify()
        {   }
    }
}
