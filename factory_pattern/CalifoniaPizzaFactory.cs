using System;
using designpatterns.factory_pattern.CalifoniaPizza;
namespace designpatterns.factory_pattern
{
    public class CalifoniaPizzaFactory : PizzaStore
    {
        public CalifoniaPizzaFactory()
        {
            Console.WriteLine("캘리포니아 피자 지점입니다.");
        }

        public override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
            {
                return new CalifoniaCheesePizza();
            }
            else if (type.Equals("pepperoni"))
            {
                return new CalifoniaPepperoniPizza();
            }
            else if (type.Equals("clam"))
            {
                return new CalifoniaClamPizza();
            }
            else if (type.Equals("veggie"))
            {
                return new CalifoniaVeggiePizza();
            }
            else
            {
                return null;
            }
        }
    }
}