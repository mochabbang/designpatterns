using System;
namespace designpatterns.factory_pattern.CicagoPizza
{
    public class CicagoVeggiePizza : Pizza
    {
        public CicagoVeggiePizza()
        {
            Console.WriteLine("시카고 스타일의 야채 피자를 만듭니다.");
        }
    }
}