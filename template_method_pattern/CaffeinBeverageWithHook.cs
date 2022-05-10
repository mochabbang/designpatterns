using System;
namespace designpatterns.template_method_pattern
{
    public class CaffeinBeverageWithHook
    {
        public void PrepareRecipe() 
        {
            BoilWater();
            Brew();
            PourInCur();
            if(CustomerWantsCondiments())
            {
                AddCondiments();
            }
            
        }

        // 우려내기!
        public abstract void Brew();

        // 첨가물 추가!
        public abstract void AddCondiments();

        public void BoilWater() 
        {
            Consolele.WriteLine("물 끓이는 중");
        }

        public void PourInCur()
        {
            Console.WriteLine("컵에 따르는 중");
        }

        // Hook 메소드
        /*
         * 후크(Hook)는 추상 클래스에서 선언되지만 기본적인 내용만 구현! 아무 코드가 들어있지 않는 메소드
         */
        public bool CustomerWantsCondiments() 
        {
            return true;
        }
    }
}