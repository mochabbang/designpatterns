namespace designpatterns.singleton_pattern
{
    public class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;
        private static ChocolateBoiler chocolateBoiler;

        private ChocolateBoiler() {
            empty = true;
            boiled = false;
        }

        public static ChocolateBoiler getInstance() {
            if(chocolateBoiler == null) {
                chocolateBoiler = new ChocolateBoiler();
            }

            return chocolateBoiler;
        }

        public void fill() {
            if (isEmpty()) {    // 가득 찰 경우에 empty, boiled false로 변경
                empty = false;
                boiled = false;
                // 보일러에 우유와 초콜릿 혼합한 재료를 넣음
            }
        }

        public void drain() {
            if(!isEmpty() && isBoiled()) {
                // 끓인 재료를 다음 단계로 넘김
                empty = true;
            }
        }

        public void boil() {
            if(!isEmpty() && !isBoiled()) {
                // 재료를 끓임
                boiled = true;
            }
        }

        public bool isEmpty() {
            return empty;
        }

        public bool isBoiled() {
            return boiled;
        }
    }
}