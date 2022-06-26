namespace designpatterns.factory_pattern
{
    public interface IPizza
    {
        // 재료준비
        void Prepare();
        // 빵 굽기
        void Bake();
        // 피자커팅
        void Cut();
        // 박스 담기
        void Box();

    }
}