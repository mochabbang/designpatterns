using System;
namespace designpatterns.factory_pattern.CalifoniaPizza
{
    public class CalifoniaClamPizza : Pizza
    {
        public CalifoniaClamPizza()
        {
            Console.WriteLine("캘리포니아 스타일의 조개 피자를 만듭니다.");
        }
    }
}