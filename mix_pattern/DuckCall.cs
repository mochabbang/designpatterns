using System;
namespace designpatterns.mix_pattern
{
    public class DuckCall: IQuackable
    {
        Observable observable;

        public DuckCall()
        {
            observable = new Observable(this);
        }

        public void Quack()
        {
            Console.WriteLine("꽉꽉");
        }

        public void RegisterObserver(IObserver observer)
        {
            observable.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            observable.NotifyObservers();
        }
    }
}