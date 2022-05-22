namespace designpatterns.proxy_pattern
{
    public class ProxyGumballMachine
    {
        int count;
        string location;
        string state;

        public ProxyGumballMachine(string location, int count) 
        {
            this.location = location;
            this.count = count;
            this.state = "동전 투입 대기중...";
        }

        public string GetLocation()
        {
            return location;
        }

        public int GetCount()
        {
            return count;
        }

        public string GetState()
        {
            return state;
        }
    }
}