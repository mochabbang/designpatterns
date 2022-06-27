using System;
namespace designpatterns.factory_pattern.NYPizza
{
    public class NYCheesePizza : Pizza
    {
        public NYCheesePizza()
        {
            name = "뉴욕 스타일 소스와 치즈피자";
            dough = "씬 크러스트 도우";
            sauce = "마리나라 소스";

            toppings.Add("잘게 썬 레지아노 치즈");

            Console.WriteLine("뉴욕 스타일의 치즈 피자를 만듭니다.");
        }
    }
}