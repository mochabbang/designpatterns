using System;
namespace designpatterns.adapter_pattern
{
    public class DuckAdapter: ITurkey
    {
        IDuck duck;
        Random rand;

        public DuckAdapter(IDuck duck) {
            this.duck = duck;
            rand = new Random();
        }

        public void gobble() {
            duck.quack();
        }

        public void fly() {
            
            if(rand.Next(5) == 0) {
                duck.fly();
            }
            
        }
    }
}