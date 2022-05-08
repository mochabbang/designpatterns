using System;
namespace designpatterns.adapter_pattern
{
    public class WildTurkey: ITurkey
    {
        public void gobble() {
            Console.WriteLine("골골");
        }

        public void fly() {
            Console.WriteLine("짧은 거리를 날고 있어요!");
        }
    }
}