﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExercise
{
    public interface IObserver
    {
        void Update(Portfolio_observer.Stock stock);
    }
}
