using System;
namespace designpatterns.template_method_pattern
{
    public abstract class CaffeineBeverage
    {
        // sealed (C#) = final (java)
        public void PrepareRecipe() 
        {
            BoilWater();
            Brew();
            PourInCur();
            AddCondiments();
        }

        // 우려내기!
        public abstract void Brew();

        // 첨가물 추가!
        public abstract void AddCondiments();

        public void BoilWater() 
        {
            Console.WriteLine("물 끓이는 중");
        }

        public void PourInCur()
        {
            Console.WriteLine("컵에 따르는 중");
        }
    }
}