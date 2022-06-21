namespace designpatterns.decorator_pattern
{
    public abstract class CondimentDecorator: Beverage
    {
        public Beverage beverage;

        public abstract string GetDescription();
    }
}