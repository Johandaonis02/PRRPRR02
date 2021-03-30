using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDemo
{
    interface ISubject
    {
        void MailTo(Observer observer);
        void StopMailTo(Observer observer);
        void Notify();
    }
}