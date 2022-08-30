using WeatherApi.Models;
using WeatherApi.Repos;

namespace WeatherApi.RouteExtensions
{
    public static class WeatherRoutes
    {
        public static void MapWeatherRoutes(this WebApplication app)
        {
            app.MapGet("/weatherforecast", async (IWeatherRepo repo) =>
            {
                var forecast = await repo.GetRandomWeather();
                return forecast;
            })
            .WithName("GetWeatherForecast");

            /*
             * Demonstrates request body binding using WeatherForecast
             * 
             * Example Post Request:
             * {
                    "date": "2022-08-31T14:12:53.4699393-04:00",
                    "temperatureC": 39,
                    "summary": "Cool"
                }
             */
            app.MapPost("/weatherforecast", async (IWeatherRepo repo, WeatherForecast newForecast) =>
            {
                var result = await repo.AddWeatherRecord(newForecast);
                return result;
            });

            //Demonstrates route parameter binding along with request body binding
            app.MapPut("/weatherforecast/{id}", async (IWeatherRepo repo, int id, WeatherForecast forecast) =>
            {
                var result = await repo.UpdateWeatherRecord(forecast);
                return result;
            });
        }
    }
}
