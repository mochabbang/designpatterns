using System;
namespace designpatterns.factory_pattern.NYPizza
{
    public class NYPepperoniPizza : Pizza
    {
        public NYPepperoniPizza()
        {
            Console.WriteLine("뉴욕 스타일의 치즈 피자를 만듭니다.");
        }
    }
}