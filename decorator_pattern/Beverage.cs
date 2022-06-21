namespace designpatterns.decorator_pattern
{
    public abstract class Beverage
    {
        private string description;

        public abstract double GetCost();

        public string GetDescription() {
            return description;
        }

        public void SetDescription(string description) {
            
            if(string.IsNullOrEmpty(description))
            {
                this.description = "제목 없음";
            }
            else 
            {
                this.description = description;
            }
        }
    }
}