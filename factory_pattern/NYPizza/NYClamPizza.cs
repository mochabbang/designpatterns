using System;
namespace designpatterns.factory_pattern.NYPizza
{
    public class NYClamPizza : Pizza
    {
        public NYClamPizza()
        {
            Console.WriteLine("뉴욕 스타일의 조개 피자를 만듭니다.");
        }
    }
}