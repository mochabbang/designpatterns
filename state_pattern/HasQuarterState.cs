namespace designpatterns.state_pattern
{
    public class HasQuarterState: IState
    {
        GumballMachine gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

         void InsertQuater() 
         {
             Console.WriteLine("동전은 한 개만 넣어 주세요.");
         }

         void EjectQuater() 
         {
             Console.WriteLine("동전이 반환됩니다.");
             gumballMachine.SetState(gumballMachine.NoQuarterState());
         }

         void TurnCrank() 
         {
              Console.WriteLine("손잡이를 돌리셨습니다.");
              gumballMachine.SetState(gumballMachine.GetSoldState());
         }

         void Dispense() 
         {
              Console.WriteLine("알맹이를 내보낼 수 없습니다.");
         }
    }
}