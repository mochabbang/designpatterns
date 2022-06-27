using System;
namespace designpatterns.factory_pattern.CicagoPizza
{
    public class CicagoClamPizza : Pizza
    {
        public CicagoClamPizza()
        {
            Console.WriteLine("시카고 스타일의 조개 피자를 만듭니다.");
        }
    }
}