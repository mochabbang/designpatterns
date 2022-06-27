using System;
namespace designpatterns.factory_pattern.CicagoPizza
{
    public class CicagoCheesePizza : Pizza
    {
        public CicagoCheesePizza()
        {
            name = "시카고 스타일 소스와 치즈피자";
            dough = "오리지널 도우";
            sauce = "살사 소스";

            toppings.Add("잘게 썬 파마산 치즈");


            Console.WriteLine("시카고 스타일의 치즈 피자를 만듭니다.");
        }
    }
}