namespace designpatterns.template_method_pattern
{
    public class Tea: CaffeineBeverage
    {
        public void Brew()
        {
            Console.WriteLine("찻잎을 우려내는 중");
        }

        public void AddCondiments()
        {
            Console.WriteLine("레몬을 추가하는 중");
        }
    }
}