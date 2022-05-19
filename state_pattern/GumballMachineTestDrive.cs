using System;
namespace designpatterns.state_pattern
{
    public class GumballMachineTestDrive: IProgram
    {
        public void Execute()
        {
            GumballMachine gumballMachine = new GumballMachine(5);

            Console.WriteLine(gumballMachine);

            gumballMachine.insertQuater();
            gumballMachine.turnCrank();
            Console.WriteLine("==========================");

            Console.WriteLine(gumballMachine);

            gumballMachine.insertQuater();
            gumballMachine.ejectQuater();
            gumballMachine.turnCrank();

            Console.WriteLine("==========================");

            Console.WriteLine(gumballMachine);

            gumballMachine.insertQuater();
            gumballMachine.turnCrank();
            gumballMachine.insertQuater();
            gumballMachine.turnCrank();
            gumballMachine.ejectQuater();

            Console.WriteLine("==========================");

            Console.WriteLine(gumballMachine);

            gumballMachine.insertQuater();
            gumballMachine.insertQuater();
            gumballMachine.turnCrank();
            gumballMachine.insertQuater();
            gumballMachine.turnCrank();
            gumballMachine.insertQuater();
            gumballMachine.turnCrank();

            Console.WriteLine("==========================");
            
            Console.WriteLine(gumballMachine);
        }
    }
}