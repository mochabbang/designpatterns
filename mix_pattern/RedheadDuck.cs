using System;
namespace designpatterns.mix_pattern
{
    public class RedheadDuck: IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("꽥꽥");
        }
    }
}