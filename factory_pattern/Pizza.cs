namespace designpatterns.factory_pattern
{
    public abstract class Pizza : IPizza
    {
        public override void Prepare()
        {
            Console.WriteLine("재료 준비 중 입니다.");
        }

        public override void Bake()
        {
            Console.WriteLine("도우 + 토핑을 올리고 오븐에서 굽고있습니다..");
        }

        public override void Cut()
        {
            Console.WriteLine("피자를 자르고 있습니다.");
        }

        public override void Box()
        {
            Console.WriteLine("박스에 담습니다.");
        }
    }
}