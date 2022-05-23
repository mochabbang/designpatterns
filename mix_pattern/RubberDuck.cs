using System;
namespace designpatterns.mix_pattern
{
    public class RubberDuck: IQuackable
    {
        Observable observable;
        string name;

        public RubberDuck()
        {
            observable = new Observable(this);
            this.name = "고무오리";
        }

        public void Quack()
        {
            Console.WriteLine("삑삑");
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