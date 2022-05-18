namespace designpatterns.state_pattern
{
    public class SoldState: IState
    {
        GumballMachine gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

         void InsertQuater() {}

         void EjectQuater() {}

         void TurnCrank() {}

         void Dispense() {}
    }
}