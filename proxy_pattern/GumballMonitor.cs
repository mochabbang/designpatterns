using System;
namespace designpatterns.proxy_pattern
{
    public class GumballMonitor
    {
        ProxyGumballMachine gumballMachine;

        public GumballMonitor(ProxyGumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Report()
        {
            Console.WriteLine("뽑기 기계 위치: " + gumballMachine.GetLocation());
            Console.WriteLine("현재 재고: " + gumballMachine.GetCount());
            Console.WriteLine("현재 상태: " + gumballMachine.GetState());
        }
    }
}