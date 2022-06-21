using System;
namespace designpatterns.observer_pattern
{
    public class ForecastDisplay: IObserver, IDisplayElement
    {
        private WeatherData weatherData;
        private float currentPressure = 29.92f;
        private float lastPressue;

        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void update(float temp, float humidity, float pressure)
        {
            lastPressue = currentPressure;
            currentPressure = weatherData.GetPressue();
        }

        public void display()
        {
            
        }
    }
}