using System;
namespace designpatterns.factory_pattern
{
    public class ExcuteFactory : IProgram
    {
        public void Execute()
        {
            PizzaStore nyPizzaStore = new NYPizzaFactory();
            nyPizzaStore.OrderPizza("cheese");

            Console.WriteLine("");
            Console.WriteLine("");

            PizzaStore cicagoStore = new CicagoPizzaFactory();
            cicagoStore.OrderPizza("cheese");

        }
    }
}