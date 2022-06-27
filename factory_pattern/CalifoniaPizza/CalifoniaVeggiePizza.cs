using System;
namespace designpatterns.factory_pattern.CalifoniaPizza
{
    public class CalifoniaVeggiePizza : Pizza
    {
        public CalifoniaVeggiePizza()
        {
            Console.WriteLine("캘리포니아 스타일의 야채 피자를 만듭니다.");
        }
    }
}