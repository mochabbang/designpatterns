using System;
namespace designpatterns.template_method_pattern
{
    public class DuckSortTestDrive: IProgram
    {
        public void Execute() 
        {
            Duck[] ducks = {
                new Duck("Daffy", 8),
                new Duck("Dewey", 2),
                new Duck("Howard", 7),
                new Duck("Louie", 2),
                new Duck("Donald", 10),
                new Duck("Huey", 2)
            };

            Console.WriteLine("정렬 전 :");
            Display(ducks);

            Array.Sort(ducks);

            Console.WriteLine("정렬 후 :");
            Display(ducks);
        }

        public static void Display(Duck[] ducks) {
            foreach(Duck d in ducks) {
                Console.WriteLine(d.ToString());
            }
        } 
    }
}