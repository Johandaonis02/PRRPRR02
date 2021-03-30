using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDemo
{
    public class Subject : ISubject
    {
        private List<Observer> observers = new List<Observer>();
        private int _int;

        public int Mail
        {
            get
            {
                return _int;
            }
            set
            {
                if (value > _int)
                {
                    Notify();
                }
                _int = value;
            }
        }

        public void MailTo(Observer observer)
        {
            observers.Add(observer);
        }

        public void StopMailTo(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
    }
}