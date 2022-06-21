namespace designpatterns.decorator_pattern
{
    public class Soy: CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", 두유";
        }

        public override double GetCost()
        {
            return beverage.GetCost() + .15;
        }
    }
}