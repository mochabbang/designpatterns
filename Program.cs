// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using designpatterns.observer_pattern;
namespace designpatterns
{
    public class Program
    {
        private static IProgram _program;
        public static void Main(string[] args) {
            //_program = new observer_pattern.ObserverPatternProgram();
            _program = new adapter_pattern.DuckTestDrive();

            _program.Execute();
        }
        
    }
}