namespace designpatterns.state_pattern
{
    public class SoldOutState: IState
    {
        GumballMachine gumballMachine;
        public SoldOutState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

         public void InsertQuater() 
         {
            Console.WriteLine("매진되었습니다. 다음 기회에 이용해 주세요.");
         }

         public void EjectQuater() 
         {
            Console.WriteLine("동전을 넣지 않으셨습니다. 동전이 반환되지 않습니다.");
         }

         public void TurnCrank() 
         {
            Console.WriteLine("매진 되었습니다.");
         }

         public void Dispense() 
         {
            Console.WriteLine("매진입니다.");
         }
    }
}