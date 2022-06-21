namespace designpatterns.decorator_pattern
{
    public class Milk: CondimentDecorator
    {
        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", 우유";
        }

        public override double GetCost()
        {
            return beverage.GetCost() + .10;
        }
    }
}