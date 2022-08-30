using System.ComponentModel.DataAnnotations;

namespace WeatherApi.Models
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        // .Net 6 doesn't have model minimal model api validation and requires custom validators or middleware
        [Required]
        public string Summary { get; set; }

        public WeatherForecast(DateTime date, int temperatureC, string? summary)
        {
            Date = date;
            TemperatureC = temperatureC;
            Summary = summary;
        }
    }
}
