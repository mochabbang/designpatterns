using System;
namespace designpatterns.mix_pattern
{
    public class RubberDuck: IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("삑삑");
        }
    }
}