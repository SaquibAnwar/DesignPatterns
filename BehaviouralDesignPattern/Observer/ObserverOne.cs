using System;

namespace DesignPatterns
{
    public class ObserverOne : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State < 3)
            {
                Console.WriteLine("\nConcreteObserverOne: Reacted to the event.");
            }
        }
    }
}