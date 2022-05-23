using System;
namespace designpatterns.mix_pattern
{
    public class DuckSimulator: IProgram
    {
        public void Execute()
        {
            DuckSimulator simulator = new DuckSimulator();

             /* 팩토리 패턴 */
            AbstractDuckFactory duckFactory = new CountingDuckFactory();

            simulator.simulate(duckFactory);
        }

        public void simulate(AbstractDuckFactory duckFactory)
        {
            /* 기존 구조 As-Is */
            // IQuackable mallardDuck = new MallardDuck();
            // IQuackable redheadDuck = new RedheadDuck();
            // IQuackable duckCall = new DuckCall();
            // IQuackable rubberDuck = new RubberDuck();

            /* 데코레이터 패턴! To-Be */
            // IQuackable mallardDuck = new QuackCounter(new MallardDuck());
            // IQuackable redheadDuck = new QuackCounter(new RedheadDuck());
            // IQuackable duckCall = new QuackCounter(new DuckCall());
            // IQuackable rubberDuck = new QuackCounter(new RubberDuck());

            /* 팩토리 패턴 */
            IQuackable mallardDuck = duckFactory.createMallardDuck();
            IQuackable redheadDuck = duckFactory.createRedheadDuck();
            IQuackable duckCall = duckFactory.createDuckCall();
            IQuackable rubberDuck = duckFactory.createRubberDuck();
            
            // Goose Adpater!
            IQuackable gooseDuck = new GooseAdapter(new Goose());
            
            Console.WriteLine("\n오리 시뮬레이션 게임(+ 컴포지트)");
            Flock flockOfDucks = new Flock();

            flockOfDucks.Add(redheadDuck);
            flockOfDucks.Add(duckCall);
            flockOfDucks.Add(rubberDuck);
            flockOfDucks.Add(gooseDuck);

            Flock flockOfMallards = new Flock();

            IQuackable mallardOne = duckFactory.createMallardDuck();
            IQuackable mallardTwo = duckFactory.createMallardDuck();
            IQuackable mallardThree = duckFactory.createMallardDuck();
            IQuackable mallardFour = duckFactory.createMallardDuck();

            flockOfMallards.Add(mallardOne);
            flockOfMallards.Add(mallardTwo);
            flockOfMallards.Add(mallardThree);
            flockOfMallards.Add(mallardFour);

            flockOfDucks.Add(flockOfMallards);

            // Console.WriteLine("\n오리 시뮬레이션 게임: 전체 무리");
            // simulate(flockOfDucks);

            // Console.WriteLine("\n오리 시뮬레이션 게임: 물오리 무리");
            // simulate(flockOfMallards);

            Console.WriteLine("\n오리 시뮬레이션 게임(+ 옵저버)");
            Quacklogist quacklogist = new Quacklogist();
            flockOfDucks.RegisterObserver(quacklogist);

            simulate(flockOfDucks);

            // Console.WriteLine("\n오리 시뮬레이션 게임(+ 추상팩토리)");

            // simulate(mallardDuck);
            // simulate(redheadDuck);
            // simulate(duckCall);
            // simulate(rubberDuck);
            // simulate(gooseDuck);

            Console.WriteLine("오리가 소리 낸 횟수: " + QuackCounter.GetQuacks() + " 번");
        }
        
        public void simulate(IQuackable duck)
        {
            duck.Quack();
        }

        // public void simulate()
        // {
        //     /* 기존 구조 As-Is */
        //     // IQuackable mallardDuck = new MallardDuck();
        //     // IQuackable redheadDuck = new RedheadDuck();
        //     // IQuackable duckCall = new DuckCall();
        //     // IQuackable rubberDuck = new RubberDuck();

        //     /* 데코레이터 패턴! To-Be */
        //     // IQuackable mallardDuck = new QuackCounter(new MallardDuck());
        //     // IQuackable redheadDuck = new QuackCounter(new RedheadDuck());
        //     // IQuackable duckCall = new QuackCounter(new DuckCall());
        //     // IQuackable rubberDuck = new QuackCounter(new RubberDuck());

        //     /* 팩토리 패턴 */
        //     AbstractDuckFactory duckFactory = new CountingDuckFactory();

        //     // Goose Adpater!
        //     IQuackable gooseDuck = new QuackCounter(new GooseAdapter(new Goose()));
            
        //     Console.WriteLine("\n오리 시뮬레이션 게임(+ 데코레이터)");

        //     simulate(mallardDuck);
        //     simulate(redheadDuck);
        //     simulate(duckCall);
        //     simulate(rubberDuck);
        //     simulate(gooseDuck);

        //     Console.WriteLine("오리가 소리 낸 횟수: " + QuackCounter.GetQuacks() + " 번");
        // }

       
    }
}