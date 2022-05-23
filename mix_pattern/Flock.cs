using System.Collections.Generic;
using System.Linq;
namespace designpatterns.mix_pattern
{
    public class Flock: IQuackable
    {
        List<IQuackable> quackers = new List<IQuackable>();

        public void Add(IQuackable quacker)
        {
            quackers.Add(quacker);
        }

        public void Quack()
        {
            foreach(IQuackable quacker in quackers)
            {
                quacker.Quack();
            }
        }
    }
}