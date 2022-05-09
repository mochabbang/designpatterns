namespace designpatterns.singleton_pattern
{
    public class Singleton
    {
        private static Singleton uniqueInstance = null;

        // 기타 인스턴스 변수
        private Singleton() {}          // 생성자를 private로 하게 될 경우 변수 선언 구조가 Singleton만 생성할 수 있다!

        public static Singleton getInstance() {
            if (uniqueInstance == null) {
                uniqueInstance = new Singleton();
            }

            return uniqueInstance;
        }

        // 기타 메소드
        
    }
}