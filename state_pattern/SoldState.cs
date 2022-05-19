namespace designpatterns.state_pattern
{
    public class SoldState: IState
    {
        GumballMachine gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertQuater()
        {
            Console.WriteLine("알맹이를 내보내고 있습니다.");
        }

        public void EjectQuater() 
        {
            Console.WriteLine("이미 알맹이를 뽑으셨습니다.");
        }

        public void TurnCrank() 
        {
            Console.WriteLine("손잡이는 한 번만 돌려주세요.");
        }

        public void Dispense() 
        {
            gumballMachine.releaseBall();

            if (gumballMachine.GetCount() == 0) {
                Console.WriteLine("더 이상 알맹이가 없습니다.");
                gumballMachine.SetState(gumballMachine.GetSoldOutState());
            }
            else {
                gumballMachine.SetState(gumballMachine.GetNoQuaterState());
            }
        }
    }
}