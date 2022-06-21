namespace designpatterns.decorator_pattern
{
    public class HouseBlend: Beverage
    {
        public HouseBlend() 
        {
            SetDescription("하우스 블렌드 커피");
        }

        public override double GetCost() 
        {
            return 0.89;
        }
    }
}