namespace designpatterns.state_pattern
{
    public class HasQuarterState: IState
    {
        GumballMachine gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertQuater() 
        {
             Console.WriteLine("동전은 한 개만 넣어 주세요.");
        }

        public void EjectQuater() 
        {
             Console.WriteLine("동전이 반환됩니다.");
             gumballMachine.SetState(gumballMachine.GetNoQuaterState());
        }

        public void TurnCrank() 
        {
              Console.WriteLine("손잡이를 돌리셨습니다.");
              gumballMachine.SetState(gumballMachine.GetSoldState());
        }

        public void Dispense() 
        {
              Console.WriteLine("알맹이를 내보낼 수 없습니다.");
        }
    }
}