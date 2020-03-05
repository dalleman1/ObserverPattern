using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExercise
{
    public abstract class Stock_subject
    {
        List<IObserver> observers = new List<IObserver>();
        
        void Attach(IObserver obs)
        {
            observers.Add(obs);
        }

        void Dettach(IObserver obs)
        {
            observers.Remove(obs);
        }

        void Notify()
        {
            foreach (var obs in observers)
            {
                obs.update(Random data);
            }
        }
    }
}
