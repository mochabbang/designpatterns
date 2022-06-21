namespace designpatterns.decorator_pattern
{
    public class Espresso: Beverage
    {
        public Espresso() 
        {
            SetDescription("에스프레소"); 
        }

        public override double GetCost()
        {
            return 1.99;
        }
    }
}