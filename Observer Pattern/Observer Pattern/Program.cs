using System;

namespace ObserverPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();

            Observer observer1 = new Observer("Karl");
            subject.MailTo(observer1);

            Observer observer2 = new Observer("Kalle");
            subject.MailTo(observer2);

            subject.Mail++;

            Observer observer3 = new Observer("Knut");
            subject.MailTo(observer3);

            subject.Mail++;

            subject.StopMailTo(observer3);

            subject.Mail++;

            Console.ReadLine();
        }
    }
}