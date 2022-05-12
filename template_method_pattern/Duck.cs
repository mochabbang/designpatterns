using System;
namespace designpatterns.template_method_pattern
{
    public class Duck: IComparable<Duck>
    {
        string name;
        int weight;

        public Duck(string name, int weight) {
            this.name = name;
            this.weight = weight;
        }

        public string ToString() {
            return name + " 체중: " + weight;
        }

        public int CompareTo(Duck otherDuck) {
            if (this.weight < otherDuck.weight) {
                return -1;
            }
            else if (this.weight == otherDuck.weight) {
                return 0;
            }
            else {
                return 1;
            }

        }
    }
}