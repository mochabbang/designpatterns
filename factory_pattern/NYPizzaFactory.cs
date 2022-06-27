using System;
using designpatterns.factory_pattern.NYPizza;

namespace designpatterns.factory_pattern
{
    public class NYPizzaFactory : PizzaStore
    {
        public NYPizzaFactory()
        {
            Console.WriteLine("뉴욕피자지점 입니다.");
        }

        public override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
            {
                return new NYCheesePizza();
            }
            else if (type.Equals("pepperoni"))
            {
                return new NYPepperoniPizza();
            }
            else if (type.Equals("clam"))
            {
                return new NYClamPizza();
            }
            else if (type.Equals("veggie"))
            {
                return new NYVeggiePizza();
            }
            else
            {
                return null;
            }
        }
    }
}