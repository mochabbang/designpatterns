namespace designpatterns.observer_pattern
{
    public class ObserverPatternProgram: IProgram
    {
        public void Execute() {
            WeatherData weatherData = new WeatherData();  // ISubject에 대한 클래스 객체 생성

            CurrentConditionDisplay currentDisplay = new CurrentConditionDisplay(weatherData); // IObserver에 대한 클래스 객체 생성
            //StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);

            weatherData.setMeasurements(80, 65, 30.4f);
            //weatherData.setMeasurements(82, 70, 30.4f);
        }
    }
}