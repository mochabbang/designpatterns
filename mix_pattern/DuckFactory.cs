namespace designpatterns.mix_pattern
{
    public class DuckFactory: AbstractDuckFactory
    {
        public override IQuackable createMallardDuck()
        {
            return new MallardDuck();
        }

        public override IQuackable createRedheadDuck()
        {
            return new RedheadDuck();
        }

        public override IQuackable createDuckCall()
        {
            return new DuckCall();
        }

        public override IQuackable createRubberDuck()
        {
            return new RubberDuck();
        }
    }
}