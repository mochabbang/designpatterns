namespace designpatterns.proxy_pattern
{
    public class ProxyGumballMachineTestDrive: IProgram
    {
        public void Execute()
        {
            int count = 0;

            ProxyGumballMachine gumballMachine = new ProxyGumballMachine("Suwon", 112);

            GumballMonitor monitor = new GumballMonitor(gumballMachine);

            monitor.Report();

        }
    }
}