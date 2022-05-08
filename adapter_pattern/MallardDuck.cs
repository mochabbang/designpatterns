using System;
namespace designpatterns.adapter_pattern
{
    public class MallardDuck: IDuck
    {
        public void quack() {
            Console.WriteLine("꽥");
        }

        public void fly() {
            Console.WriteLine("날고있어요!!");
        }
    }
}