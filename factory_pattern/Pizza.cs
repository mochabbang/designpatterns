using System.Collections.Generic;
using System;
namespace designpatterns.factory_pattern
{
    public abstract class Pizza : IPizza
    {
        public string name;
        public string dough;
        public string sauce;
        public List<string> toppings = new List<string>();

        public void Prepare()
        {
            Console.WriteLine("재료 준비 중 입니다.");
            Console.WriteLine("=======================");
            Console.WriteLine("준비 중: " + name);
            Console.WriteLine("{0} 돌리는 중..", dough);
            Console.WriteLine("{0} 뿌리는 중..", sauce);
            Console.WriteLine("토핑을 올리는 중..");
            foreach (string topping in toppings)
            {
                Console.WriteLine(" " + topping);
            }
            Console.WriteLine("=======================");
        }

        public void Bake()
        {
            Console.WriteLine("175도에서 25분간 굽는 중입니다.");
        }

        public void Cut()
        {
            Console.WriteLine("피자를 사선으로 자르고 있습니다.");
        }

        public void Box()
        {
            Console.WriteLine("상자에 피자를 담습니다.");
        }

        public string GetName()
        {
            return name;
        }

        public string GetDough()
        {
            return dough;
        }

        public string GetSauce()
        {
            return sauce;
        }
    }
}