// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using designpatterns.observer_pattern;
namespace designpatterns
{
    public class Program
    {
        private static IProgram _program = null;
        public static void Main(string[] args) {
            /* 옵저버 패턴 */
            //_program = new observer_pattern.ObserverPatternProgram();
            /* 어댑터 패턴 */
            //_program = new adapter_pattern.DuckTestDrive();
            /* 퍼사드 패턴 */
            //_program = new facade_pattern.FacadePatternProgram();
            /* 템플릿 메소드 */
            //_program = new template_method_pattern.TemplatePatternProgram();
            _program = new template_method_pattern.DuckSortTestDrive();

            _program.Execute();
        }
        
    }
}