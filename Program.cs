// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using designpatterns.observer_pattern;
namespace designpatterns
{
    public class Program
    {
        private static IProgram _program = null;
        public static void Main(string[] args)
        {
            /* 옵저버 패턴 */
            //_program = new observer_pattern.ObserverPatternProgram();
            /* 어댑터 패턴 */
            //_program = new adapter_pattern.DuckTestDrive();
            /* 퍼사드 패턴 */
            //_program = new facade_pattern.FacadePatternProgram();
            /* 템플릿 메소드 */
            //_program = new template_method_pattern.TemplatePatternProgram();
            //_program = new template_method_pattern.DuckSortTestDrive();
            /* 반복자 패턴 */
            //_program = new iterator_pattern.MenuTestDrive();
            /* 컴포지트 패턴 */
            // _program = new composite_pattern.MenuTestDrive();
            /* 상태 패턴 */
            //_program = new state_pattern.GumballMachineTestDrive();
            /* 프록시 패턴 */
            //_program = new proxy_pattern.ProxyGumballMachineTestDrive();
            /* 복합 패턴 */
            //_program = new mix_pattern.DuckSimulator();
            /* 전략 패턴 */
            //_program = new stratege_pattern.StrategeExecute();
            /* 데코레이터 패턴 */
            //_program = new decorator_pattern.Executedecoratorpattern();
            /* 팩토리 패턴 */
            _program = new factory_pattern.ExcuteFactory();

            _program.Execute();
        }

    }
}