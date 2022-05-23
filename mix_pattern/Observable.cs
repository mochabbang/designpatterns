using System;
namespace designpatterns.mix_pattern
{
    public class Observable: IQuackObserverable
    {
        List<IObserver> observers = new List<IObserver>();
        IQuackObserverable duck;

        public Observable(IQuackObserverable duck)
        {
            this.duck = duck;
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(duck);
            }
        }
    }
}