namespace designpatterns.decorator_pattern
{
    public class Whip: CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;    
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", 휘핑 크림";
        }

        public override double GetCost()
        {
            return beverage.GetCost() + 0.10;
        }
    }
}