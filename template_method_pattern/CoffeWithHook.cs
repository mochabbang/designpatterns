using System;
namespace designpatterns.template_method_pattern
{
    public class CoffeWithHook: CaffeinBeverageWithHook
    {
        public override void Brew()
        {
            Console.WriteLine("필터로 커피를 우려내는 중");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("설탕과 우유를 추가하는 중");
        }

        public override bool CustomerWantsCondiments()
        {
            string answer = GetUserInput();

            if (answer.ToLower().Equals("y"))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public string GetUserInput() 
        {
            Console.Write("커피에 우유와 설탕을 넣을까요? (y/n) ?");
            
            string answer = Console.ReadLine();

            return answer;
        }
    }
}