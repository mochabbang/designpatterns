namespace designpatterns.adapter_pattern
{
    public class TurkeyAdapter: IDuck
    {
        ITurkey turkey;

        public TurkeyAdapter(ITurkey turkey) {
            this.turkey = turkey;
        }

        public void quack() {
            turkey.gobble();
        }

        public void fly() {
            for (int i = 0; i < 5; i++)
            {
                turkey.fly();
            }
        }
    }
}