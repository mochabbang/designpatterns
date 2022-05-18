using System.Text;
using System;
namespace designpatterns.state_pattern
{
    public class GumballMachine
    {
        /// 매진
        private IState soldOutState;
        /// 동전 없음
        private IState noQuaterState;
        /// 동전 있음
        private IState hasQuaterState;
        /// 판매
        private IState soldState;

        private IState state;
        int count = 0;

        public GumballMachine(int numberGumball) {
            noQuaterState = new NoQuaterState(this);
            hasQuaterState = new HasQuarterState(this);
            soldOutState = new SoldOutState(this);
            soldState = new SoldState(this);

            this.count = numberGumball;
            if (numberGumball > 0) 
            {
                state = noQuaterState;
            }
            else 
            {
                state = soldOutState;
            }
        }         

        /// <summary>요약 : 동전 넣기</summary>
        public void insertQuater()
        {
            if (state == HAS_QUATER) {
                Console.WriteLine("동전은 한 개만 넣어 주세요.");
            }
            else if (state == NO_QUATER) {
                state = HAS_QUATER;
                Console.WriteLine("동전을 넣으셨습니다.");
            }
            else if (state == SOLD_OUT) {
                Console.WriteLine("매진되었습니다. 다음 기회에 이용해 주세요.");
            }
            else if (state == SOLD) {
                Console.WriteLine("알맹이를 내보내고 있습니다.");
            }
        }

        /// <summary>요약 : 동전 반환</summary>
        public void ejectQuater()
        {
            if (state == HAS_QUATER) {
                Console.WriteLine("동전이 반환됩니다.");
                state = NO_QUATER;
            }
            else if (state == NO_QUATER) {
                Console.WriteLine("동전을 넣어 주세요.");
            }
            else if (state == SOLD) {
                Console.WriteLine("이미 알맹이를 뽑으셨습니다.");
            } 
            else if (state == SOLD_OUT) {
                Console.WriteLine("동전을 넣지 않으셨습니다. 동전이 반환되지 않습니다.");
            }
        }

        /// <summary>요약 : 손잡이를 돌리는 경운</summary>
        public void turnCrank() 
        {
            if (state == SOLD) {
                Console.WriteLine("손잡이는 한 번만 돌려주세요.");
            } 
            else if (state == NO_QUATER) {
                Console.WriteLine("동전을 넣어 주세요.");
            }
            else if (state == SOLD_OUT) {
                Console.WriteLine("매진 되었습니다.");
            }
            else if (state == HAS_QUATER) {
                Console.WriteLine("손잡이를 돌리셨습니다.");
                state = SOLD;
                dispense();
            }
        }

        public void dispense()
        {
            if (state == SOLD) {
                Console.WriteLine("알맹이를 내보내고 있습니다.");

                count = count - 1;

                if (count == 0) {
                    Console.WriteLine("더 이상 알맹이가 없습니다.");
                    state = SOLD_OUT;
                }
                else {
                    state = NO_QUATER;
                }
            }
            else if (state == NO_QUATER) {
                Console.WriteLine("동전을 넣어 주세요.");
            }
            else if (state == SOLD_OUT) {
                Console.WriteLine("매진입니다.");
            }
            else if (state == HAS_QUATER) {
                Console.WriteLine("알맹이를 내보낼 수 없습니다.");
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("주식회사 왕뽑기");
            stringBuilder.AppendLine("C#으로 돌아가는 최신형 뽑기 기계");
            stringBuilder.AppendLine("남은 개수 : " + count.ToString() + "개");
            stringBuilder.AppendLine("동전 투입 대기중");

            return stringBuilder.ToString();
        }

        public void SetState(IState state)
        {
            this.state = state;
        }

        public IState GetHasQuarterState()
        {
            return hasQuaterState;
        }

        public IState GetNoQuaterState() {
            return noQuaterState;
        }

        public IState GetSoldState() {
            return soldState;
        }

        public IState GetSoldOutState() {
            return soldOutState;
        }
    }
}