using System;
using System.Collections.Generic;
using System.Threading;

namespace DesignPatterns
{
    public class Subject : ISubject
    {
        public int State { get; set; } = -0;

        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            System.Console.WriteLine("\nSubject: Attached an Observer.");
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            System.Console.WriteLine("\nSubject: Dettached an Observer.");
            this._observers.Remove(observer);
        }

        public void Notify()
        {
            System.Console.WriteLine("\nSubject: Notifying Observers....");

            foreach(var observer in _observers)
            {
                observer.Update(this);
            }
            
        }

        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nSubject: I'm doing something important.");
            this.State = new Random().Next(0, 10);

            Thread.Sleep(15);

            Console.WriteLine("Subject: My state has just changed to: " + this.State);
            this.Notify();
        }

    }
}