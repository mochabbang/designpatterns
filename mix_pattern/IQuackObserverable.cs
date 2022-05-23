namespace designpatterns.mix_pattern
{
    public interface IQuackObserverable
    {
         public void RegisterObserver(IObserver observer);

         public void NotifyObservers();
    }
}