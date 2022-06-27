using System;
namespace designpatterns.factory_pattern.CalifoniaPizza
{
    public class CalifoniaPepperoniPizza : Pizza
    {
        public CalifoniaPepperoniPizza()
        {
            Console.WriteLine("캘리포니아 스타일의 치즈 피자를 만듭니다.");
        }
    }
}