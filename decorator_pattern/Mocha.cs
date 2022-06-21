using System;
namespace designpatterns.decorator_pattern
{
    public class Mocha: CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;      
            Console.WriteLine(this.beverage.GetDescription());     
        }

        public override string GetDescription()
        {
            Console.WriteLine(beverage);
            return beverage.GetDescription() + ", 모카";
        }

        public override double GetCost()
        {
            Console.WriteLine(beverage);
            return beverage.GetCost() + 0.20;
        }
    }
}