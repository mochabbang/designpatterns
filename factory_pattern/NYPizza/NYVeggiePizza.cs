using System;
namespace designpatterns.factory_pattern.NYPizza
{
    public class NYVeggiePizza : Pizza
    {
        public NYVeggiePizza()
        {
            Console.WriteLine("뉴욕 스타일의 야채 피자를 만듭니다.");
        }
    }
}