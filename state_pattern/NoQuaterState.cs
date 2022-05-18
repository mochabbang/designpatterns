using Internal;
using System;
namespace designpatterns.state_pattern
{
    public class NoQuaterState: IState
    {
        public NoQuaterState(GumballMachine gumballMachine)
        {
            GumballMachine gumballMachine = gumballMachine;
        }

        void InsertQuater() 
        {
            Console.WriteLine("동전을 넣으셨습니다.");
            this.SetState(gumballMachine.GetHasQuarterState());
        }

        void EjectQuater() 
        {
            Console.WriteLine("동전을 넣어 주세요.");
        }

        void TurnCrank() 
        {
            Console.WriteLine("동전을 넣어주세요.");
        }

        void Dispense() 
        {
            Console.WriteLine("동전을 넣어주세요.");
        }
    }
}