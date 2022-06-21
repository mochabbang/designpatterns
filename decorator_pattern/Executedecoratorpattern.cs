using System;
namespace designpatterns.decorator_pattern
{
    public class Executedecoratorpattern: IProgram
    {
        public void Execute()
        {
            Beverage beverage = new Espresso();

            Console.WriteLine(beverage.GetDescription() + " $" + beverage.GetCost());


            Beverage beverage1 = new HouseBlend();
            //beverage1 = new Soy(beverage1);
            beverage1 = new Mocha(beverage1);
            // beverage1 = new Whip(beverage1);

            Console.WriteLine(beverage1.GetDescription() + " $" + beverage1.GetCost());
        }
    }
}