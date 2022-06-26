using System;
namespace designpatterns.factory_pattern
{
    public class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            Console.WriteLine("치즈피자 주문입니다.");
        }
    }
}