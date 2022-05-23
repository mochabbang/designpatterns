using System;
namespace designpatterns.mix_pattern
{
    public class DuckCall: IQuackable
    {
        Observable observable;

        string name;

        public DuckCall()
        {
            observable = new Observable(this);
            this.name = "오리 호출기";
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

        public override string ToString()
        {
            return name;
        }
    }
}