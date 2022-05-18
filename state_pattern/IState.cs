namespace designpatterns.state_pattern
{
    public interface IState
    {
         void InsertQuater() {}

         void EjectQuater() {}

         void TurnCrank() {}

         void Dispense() {}
    }
}