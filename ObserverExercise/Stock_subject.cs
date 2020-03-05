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
        
        public void Attach(IObserver obs)
        {
            observers.Add(obs);
        }

        public void Dettach(IObserver obs)
        {
            observers.Remove(obs);
        }

        public abstract void Notify();
    }
}
