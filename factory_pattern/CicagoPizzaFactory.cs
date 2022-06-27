using System;
using designpatterns.factory_pattern.CicagoPizza;
namespace designpatterns.factory_pattern
{
    public class CicagoPizzaFactory : PizzaStore
    {
        public CicagoPizzaFactory()
        {
            Console.WriteLine("시카고 피자 지점입니다.");
        }

        public override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
            {
                return new CicagoCheesePizza();
            }
            else if (type.Equals("pepperoni"))
            {
                return new CicagoPepperoniPizza();
            }
            else if (type.Equals("clam"))
            {
                return new CicagoClamPizza();
            }
            else if (type.Equals("veggie"))
            {
                return new CicagoVeggiePizza();
            }
            else
            {
                return null;
            }
        }
    }
}