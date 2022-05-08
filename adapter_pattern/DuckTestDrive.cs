using System;
namespace designpatterns.adapter_pattern
{
    public class DuckTestDrive: IProgram
    {
        public void Execute() {
            IDuck duck = new MallardDuck();

            ITurkey turkey = new WildTurkey();
            IDuck turkeyAdpater = new TurkeyAdapter(turkey);

            Console.WriteLine("칠면조가 말하길");
            turkey.gobble();
            turkey.fly();

            Console.WriteLine("\n오리가 말하길");
            TestDuck(duck);

            Console.WriteLine("\n칠면조 어댑터가 말하길");
            TestDuck(turkeyAdpater);
        } 

        public static void TestDuck(IDuck duck) {
            duck.quack();
            duck.fly();
        }
    }
}