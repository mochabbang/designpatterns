namespace designpatterns.mix_pattern
{
    public class GooseAdapter:IQuackable
    {
        Goose goose;

        Observable observable;

        public GooseAdapter(Goose goose)
        {
            this.goose = goose;
            observable = new Observable(this);
        }

        public void Quack()
        {
            goose.honk();
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
            return goose.GetGooseName();
        }
    }
}