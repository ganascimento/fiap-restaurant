using System;

namespace modelo.Domain.Entities
{
    public class WeatherForecast : Entity<Guid>
    {

        public WeatherForecast()
        {

        }
        public WeatherForecast(WeatherForecast weatherForecast)
        {
            Date = weatherForecast.Date;
            TemperatureC = weatherForecast.TemperatureC;
            TemperatureF = weatherForecast.TemperatureF;
            Summary = weatherForecast.Summary;


        }
       
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF { get; set; }

        public string Summary { get; set; }
        
    }
}
