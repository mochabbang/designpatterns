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

        private IState winnerState;

        private IState state;
        int count = 0;

        public GumballMachine(int numberGumball) {
            noQuaterState = new NoQuaterState(this);
            hasQuaterState = new HasQuarterState(this);
            soldOutState = new SoldOutState(this);
            soldState = new SoldState(this);
            winnerState = new WinnerState(this);

            this.count = numberGumball;
            if (numberGumball > 0) 
            {
                this.state = noQuaterState;
            }
            else 
            {
                this.state = soldOutState;
            }
        }         

        /// <summary>요약 : 동전 넣기</summary>
        public void insertQuater()
        {
            state.InsertQuater();
        }

        /// <summary>요약 : 동전 반환</summary>
        public void ejectQuater()
        {
            state.EjectQuater();
        }

        /// <summary>요약 : 손잡이를 돌리는 경운</summary>
        public void turnCrank() 
        {
            state.TurnCrank();
            state.Dispense();
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

        public void releaseBall()
        {
            Console.WriteLine("알맹이를 내보내고 있습니다.");
            if(this.count > 0) {
                this.count = count - 1;
            }
        }

        // 카운트 : 뽑기가능한 상품
        public int GetCount()
        {
            return this.count;
        }

        // 동전을 삽입했을 때 상태
        public IState GetHasQuarterState()
        {
            return hasQuaterState;
        }

        // 동전이 없을 때 상태
        public IState GetNoQuaterState() {
            return noQuaterState;
        }

        // 상품 판매 (내보내기) 상태
        public IState GetSoldState() {
            return soldState;
        }

        // 상품 매진 상태
        public IState GetSoldOutState() {
            return soldOutState;
        }

        // 보너스 상품!
        public IState GetWinnerState() {
            return winnerState;
        }
    }
}