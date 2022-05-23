using System;
namespace designpatterns.mix_pattern
{
    public class DuckCall: IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("꽉꽉");
        }
    }
}