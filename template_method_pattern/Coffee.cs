using System;
namespace designpatterns.template_method_pattern
{
    public class Coffee: CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("필터로 커피를 우려내는 중");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("설탕과 우유를 추가하는 중");
        }
    }
}