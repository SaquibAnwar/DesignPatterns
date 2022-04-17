using System;

namespace DesignPatterns
{
    public class ObserverTwo : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State == 0 || (subject as Subject).State >= 2)
            {
                Console.WriteLine("\nConcreteObserverTwo: Reacted to the event.");
            }
        }
    }
}