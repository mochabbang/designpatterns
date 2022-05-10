// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using designpatterns.observer_pattern;
namespace designpatterns
{
    public class Program
    {
        private static IProgram _program = null;
        public static void Main(string[] args) {
            //_program = new observer_pattern.ObserverPatternProgram();
            //_program = new adapter_pattern.DuckTestDrive();
            //_program = new facade_pattern.FacadePatternProgram();
            _program = new template_method_pattern.TemplatePatternProgram();

            _program.Execute();
        }
        
    }
}