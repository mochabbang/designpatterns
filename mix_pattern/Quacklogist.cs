using System;
namespace designpatterns.mix_pattern
{
    public class Quacklogist: IObserver
    {
        public void Update(IQuackObserverable duck)
        {
            Console.WriteLine("꽥꽥학자: " + duck.ToString() + "가 방금 소리냈다.");
        }
    }
}