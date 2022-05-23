namespace designpatterns.mix_pattern
{
    // 데코레이터 클래스! (꽉꽉 카운트 세기)
    public class QuackCounter: IQuackable
    {
        IQuackable duck;
        static int numberOfQuacks;

        public QuackCounter(IQuackable duck)
        {
            this.duck = duck;
            numberOfQuacks = 0;
        } 

        public void Quack()
        {
            duck.Quack();
            numberOfQuacks++;
        }

        public static int GetQuacks()
        {
            return numberOfQuacks;
        }
    }
}