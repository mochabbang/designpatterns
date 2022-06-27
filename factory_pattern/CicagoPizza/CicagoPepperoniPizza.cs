using System;
namespace designpatterns.factory_pattern.CicagoPizza
{
    public class CicagoPepperoniPizza : Pizza
    {
        public CicagoPepperoniPizza()
        {
            Console.WriteLine("시카고 스타일의 치즈 피자를 만듭니다.");
        }
    }
}