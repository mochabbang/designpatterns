using System;
namespace designpatterns.state_pattern
{
    public class NoQuaterState: IState
    {
        GumballMachine gumballMachine;
        public NoQuaterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertQuater() 
        {
            Console.WriteLine("동전을 넣으셨습니다.");
            gumballMachine.SetState(gumballMachine.GetHasQuarterState());
        }

        public void EjectQuater() 
        {
            Console.WriteLine("동전을 넣어 주세요.");
        }

        public void TurnCrank() 
        {
            Console.WriteLine("동전을 넣어주세요.");
        }

        public void Dispense() 
        {
            Console.WriteLine("동전을 넣어주세요.");
        }
    }
}