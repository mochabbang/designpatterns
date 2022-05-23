using System;
namespace designpatterns.mix_pattern
{
    public class RedheadDuck: IQuackable
    {
        Observable observable;

        string name;

        public RedheadDuck()
        {
            observable = new Observable(this);

            this.name = "붉은머리오리";
        }

        public void Quack()
        {
            Console.WriteLine("꽥꽥");
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            observable.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            observable.NotifyObservers();
        }

        public override string ToString()
        {
            return name;
        }
    }
}