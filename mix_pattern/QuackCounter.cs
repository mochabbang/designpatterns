namespace designpatterns.mix_pattern
{
    // 데코레이터 클래스! (꽉꽉 카운트 세기)
    public class QuackCounter: IQuackable
    {
        IQuackable duck;

        Observable observable;
        static int numberOfQuacks;

        public QuackCounter(IQuackable duck)
        {
            this.duck = duck;
            observable = new Observable(this);
            numberOfQuacks = 0;
        } 

        public void Quack()
        {
            duck.Quack();
            numberOfQuacks++;
        }

        public static int GetQuacks()
        {
            return numberOfQuacks;
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