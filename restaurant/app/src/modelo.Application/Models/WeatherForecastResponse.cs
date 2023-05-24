using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace modelo.Application.Models
{
    public class WeatherForecastResponse
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("Date")]
        public DateTime Date { get; set; }

        [JsonProperty("TemperatureC")]
        public int TemperatureC { get; set; }

        [JsonProperty("TemperatureF")]
        public int TemperatureF { get; set; }

        [JsonProperty("Summary")]
        public string Summary { get; set; }

    }
}
