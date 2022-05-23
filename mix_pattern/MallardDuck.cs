using System;
namespace designpatterns.mix_pattern
{
    public class MallardDuck: IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("꽥꽥");
        }
    }
}